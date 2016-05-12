using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Threading;
using System.Diagnostics;

namespace Dobot
{
    public partial class frmVisualDetection : Form
    {
        private frmDobot Tranceiver;
        private Capture capture;
        private RoundBlock roundBlock=new RoundBlock();
        private Controler controler;
        private Environment environment = new Environment( 150, 200, dobot.origin_x, dobot.origin_y);

        private bool captureInProgress;//开启/关闭 按钮用的变量
        private Mat preFrame;
        bool isFirstFrame = true;
        int detectInterval = 0;

        double measureTime = 0;
        int FramenNumber = 0;
        public frmVisualDetection(frmDobot Tranceiver)
        {
            InitializeComponent();
            labelTransparent();
            this.Tranceiver = Tranceiver;
            controler = new Controler(roundBlock, environment, this.Tranceiver);
            try
            {
                capture = new Capture(1);
                capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
        private void InitializePara()
        {
            trbSendDataDeadZone.Value = (int)(controler.TargetDeadzone*10);
            trbJogMaxSpeed.Value = (int)(controler.JogMaxSpeed);
            trbJogMaxAcc.Value = (int)(controler.JogMaxAcc);
            trbJogDeadzone.Value = (int)(controler.JogDeadzone*10);
            trbK_JogSpeed.Value = (int)(controler.K_JogSpeed*10000);
            trbKd_JogSpeed.Value = (int)(controler.Kd_JogSpeed*10000);
            trbPIDKp.Value = (int)(controler.Kp*1000);
            trbPIDKi.Value = (int)(controler.Ki*100);
            trbPIDKd.Value = (int)(controler.Kd*1000);
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            { 
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Mat ImageFrame = new Mat();                  
                capture.Retrieve(ImageFrame);
                    
                if (isFirstFrame)//运行第一帧
                {
                    environment.ImageSize = ImageFrame.Size;
                    preFrame = ImageFrame.Clone();
                    roundBlock.Height = Convert.ToSingle(txtHeight.Text);
                    isFirstFrame = false;
                }
                Mat pyrDown = new Mat();
                CvInvoke.PyrDown(ImageFrame, pyrDown);
                CvInvoke.PyrUp(pyrDown, ImageFrame);

                Mat showFrame = ImageFrame.Clone();
                if (!HoughGotFlag||
                    detectInterval == HoughDetectInterval)
                {
                    HoughProcess(ImageFrame, showFrame, roundBlock);
                    detectInterval = 0;
                    ibx1.Image = showFrame;                       
                    return;
                }
                detectInterval++;
                roundBlock.BlockCenterInImage = matchTemple(ImageFrame, roundBlock.image, 
                    TemplateMatchingType.SqdiffNormed, showFrame);
                roundBlock.BlockCenter = environment.axis_Dobot2User(roundBlock.BlockCenterInImage);
                if (controler.enable)
                    controler.jogSend(roundBlock.BlockCenter, true);
                ibx1.Image = showFrame;
                preFrame = ImageFrame;
                updateText(roundBlock.BlockCenterInImage);
                /**********/
                stopwatch.Stop();
                /*measureTime += stopwatch.Elapsed.TotalSeconds;
                FramenNumber++;
                if (FramenNumber==20)
                {
                    FramenNumber = 0;
                    Console.WriteLine("average frame time:"+(measureTime/20).ToString());
                    measureTime = 0;
                }*/
                controler.delta_T = (float)stopwatch.Elapsed.TotalMilliseconds;
            }
            catch(Exception excpt)
            {
                //MessageBox.Show(excpt.Message);
            }
        }
        public void updateText(Point point)
        {
            if (!IsDisposed && !Disposing && InvokeRequired)
            {
                Invoke((Action<Point>)updateText, point);
            }
            else
            {
                lblX.Text = "Detected X↓: " + point.X.ToString();
                lblY.Text = "Detected Y→: " + point.Y.ToString();

                dobot.Target_x = environment.axis_Image2Dobot(point).X;
                dobot.Target_y = environment.axis_Image2Dobot(point).Y;
                lblrealX.Text = "real X↓: " + environment.axis_Image2User(point).X.ToString();
                lblrealY.Text = "real Y→: " + environment.axis_Image2User(point).Y.ToString();

                lblsendX.Text = "send X↓: " + dobot.Target_x;
                lblsendY.Text = "send Y→: " + dobot.Target_y;
            }
        }
        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture(1);
                    capture.ImageGrabbed += ProcessFrame;
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion
            if (capture != null)
            {
                if (captureInProgress)
                {
                    Tranceiver.sendPacket(3, 0, dobot.origin_x, dobot.origin_y,dobot.origin_z, 0, 0, 1, 0, 0);
                    btnOpenCamera.Text = "Open"; 
                    capture.Pause();    
                    btnGrab.Enabled = false;
                    //tabAlgorithm.Enabled = false;
                }
                else
                {
                    //Tranceiver.sendPacket(2, 0, 0, 0, 0, 0, 0, 100, 0, 0);
                    Tranceiver.sendPacket(9, 0, controler.JogMaxSpeed, controler.JogMaxAcc, 30, 50,100, 200, 0, 30);
                    btnOpenCamera.Text = "Stop";
                    capture.Start();
                    btnGrab.Enabled = true;
                    tabAlgorithm.Enabled = true;
                }
                captureInProgress = !captureInProgress;
            }
        }
        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }      
        private void ibx1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text=  "X: " + (e.X * 640 / ibx1.Width ).ToString();
            label1.Text = "Y: " + (e.Y * 480 / ibx1.Height ).ToString();
        }
        private void btnGrab_Click(object sender, EventArgs e)
        {
            PointF center = environment.axis_Image2Dobot(roundBlock.BlockCenterInImage);
            Tranceiver.sendPacket(3,0, center.X, center.Y,
                (Convert.ToSingle(txtHeight.Text) + dobot.origin_z),
                 0,1,0,0, dobot.Target_PauseTime);
            Thread.Sleep(1000);
            Tranceiver.sendPacket(3, 0, 310,0,(Convert.ToSingle(txtHeight.Text) + dobot.origin_z)
                , 0, 0, 0, 0, dobot.Target_PauseTime);
            Thread.Sleep(1000);
            Tranceiver.sendPacket(3, 0, 300, 0,
                (Convert.ToSingle(txtHeight.Text) + dobot.origin_z+20),0,0,1,0,0);
            Thread.Sleep(1000);
            Tranceiver.sendPacket(3,0, dobot.origin_x, dobot.origin_y,
                    dobot.origin_z, 0, 0, 1, 0, 0);
        }    
        private void labelTransparent()
        {
            label2.Parent = ibx1;label2.BackColor = Color.Transparent;
            label1.Parent = ibx1; label1.BackColor = Color.Transparent;
            lblrealX.Parent = ibx1; lblrealX.BackColor = Color.Transparent;
            lblrealY.Parent = ibx1; lblrealY.BackColor = Color.Transparent;
            lblsendX.Parent = ibx1; lblsendX.BackColor = Color.Transparent;
            lblsendY.Parent = ibx1; lblsendY.BackColor = Color.Transparent;
            lblX.Parent = ibx1; lblX.BackColor = Color.Transparent;
            lblY.Parent = ibx1; lblY.BackColor = Color.Transparent;
        }
        private void frmVisualDetection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tranceiver.sendPacket(3, 0, dobot.origin_x, dobot.origin_y,
                    dobot.origin_z,0,0,1,0,0);
            Tranceiver.Show();
            Tranceiver.visualDetection = null;
            Tranceiver.visualDetetectionToolStripMenuItem.Enabled = true;
        }
        #region Send Wait   
        /*  
        bool isTracking = true;
        Thread pointSendThread;
        private void btnTracking_Click(object sender, EventArgs e)
        {
            if(isTracking)
            {
                btnTracking.Text = "Stop Tracking";
                pointSendThread = new Thread(new ParameterizedThreadStart(pointSendWait));
               // pointSendThread.Start();
               // Console.WriteLine("pointSendThread Start:"+ pointSendThread.ThreadState);
            }
            else
            {
                btnTracking.Text = "Start Tracking";
                pointSendThread.Abort();
            }
            isTracking = !isTracking;
        }
        public void pointSendWait(object a)
        {
            while (true)
            {
                if (Math.Abs(roundBlock.trackTarget.X+roundBlock.OriginXY_Dobot.X - Tranceiver.retPacket.X) < 1 &&
                            Math.Abs(roundBlock.trackTarget.Y+roundBlock.OriginXY_Dobot.Y - Tranceiver.retPacket.Y) < 1)
                {
                    roundBlock.isAtTargetPoint = true;
                    //Console.WriteLine("pointsend");
                   // break;
                }
            }
        }
        */
        #endregion
        #region View Value Settings
        int threshold = 40;
        int minSat = 0;
        private void trbThreshold_Scroll(object sender, EventArgs e)
        {
            threshold = ((TrackBar)sender).Value;
            lblThreshold.Text = "Threshold: " + threshold.ToString();
        }
        
        private void lblMinSat_Scroll(object sender, EventArgs e)
        {
            minSat = ((TrackBar)sender).Value;
            lblMinSat.Text = "Minimum Saturation: " + minSat.ToString();
        }

        private void trbSendDataDeadZone_Scroll(object sender, EventArgs e)
        {
            controler.TargetDeadzone = ((float)((TrackBar)sender).Value)/10.0f;
            lblDeadZone.Text = "DeadZone: " + controler.TargetDeadzone.ToString();
        }

        private void trbPIDKp_Scroll(object sender, EventArgs e)
        {
            controler.Kp = ((float)((TrackBar)sender).Value) / 1000.0f;
            lblPIDKp.Text = "Kp: " + controler.Kp.ToString();
        }

        private void trbPIDKd_Scroll(object sender, EventArgs e)
        {
            controler.Kd = ((float)((TrackBar)sender).Value) / 1000.0f;
            lblPIDKd.Text = "Kd: " + controler.Kd.ToString();
        }

        private void trbPIDKi_Scroll(object sender, EventArgs e)
        {
            controler.Ki = ((float)((TrackBar)sender).Value) / 100.0f;
            lblPIDKi.Text = "Ki: " + controler.Ki.ToString();
        }
        
        private void trbJogDeadzone_Scroll(object sender, EventArgs e)
        {
            controler.JogDeadzone = ((float)((TrackBar)sender).Value) / 10.0f;
            lblJogDeadzone.Text = "JogDeadzone: " + controler.JogDeadzone.ToString();
        }

        private void trbK_JogSpeed_Scroll(object sender, EventArgs e)
        {
            controler.K_JogSpeed = ((float)((TrackBar)sender).Value)/10000.0f;
            lblK_JogSpeed.Text = "K JogSpeed: " + controler.K_JogSpeed.ToString();
        }

        private void trbKd_JogSpeed_Scroll(object sender, EventArgs e)
        {
            controler.Kd_JogSpeed = ((float)((TrackBar)sender).Value)/10000.0f;
            lblKd_JogSpeed.Text = "Kd JogSpeed: " + controler.Kd_JogSpeed.ToString();
        }
        
        private void trbJogMaxSpeed_Scroll(object sender, EventArgs e)
        {
            controler.JogMaxSpeed =((TrackBar)sender).Value;
            lblJogMaxSpeed.Text = "Jog Max Speed: " + controler.JogMaxSpeed.ToString();
            Tranceiver.sendPacket(9, 0, controler.JogMaxSpeed, controler.JogMaxAcc, 30, 50, 100, 200, 0, 30);
        }       
        private void trbJogMaxAcc_Scroll(object sender, EventArgs e)
        {
            controler.JogMaxAcc = ((TrackBar)sender).Value;
            lblJogMaxAcc.Text = "Jog Max Acc: " + controler.JogMaxAcc.ToString();
            Tranceiver.sendPacket(9, 0, controler.JogMaxSpeed, controler.JogMaxAcc, 30, 50, 100, 200, 0, 30);
        }
        #endregion
        bool btnTrackingFlag = false;
        private void btnTracking_Click(object sender, EventArgs e)
        {
            if (!btnTrackingFlag)
            {
                controler.enable = true;
                btnTrackingFlag = true;
                btnTracking.Text = "Stop Tracking";
            }
            else
            {
                controler.enable = false;
                btnTrackingFlag = false;
                btnTracking.Text = "Start Tracking";
            }
        }
    }
}
