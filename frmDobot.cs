using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
namespace Dobot
{   
    public partial class frmDobot : Form
    {       
        internal frmVisualDetection visualDetection;
        internal frmWriteDraw WriteDraw;
        internal frmPickUp PickUp;
        internal Packet retPacket = new Packet();       
        public frmDobot()
        {
            InitializeComponent();
            InitializeTexts();
        }
        #region SerialPort Settings
        private void frmDobot_Load(object sender, EventArgs e)
        {
            try
            {   
                foreach (string com in System.IO.Ports.SerialPort.GetPortNames())
                    this.cmPort.Items.Add(com);
                cmPort.SelectedIndex = 1;
            }
            catch
            {
                MessageBox.Show("Not found serial port!", "Dobot");
            }
        }
        private void OpenPort()
        {
            serialPort1.WriteTimeout = 1000;  //写超时，如果底层串口驱动效率问题，能有效的避免死锁。
            serialPort1.ReadTimeout = 1000;   //读超时，同上。
            serialPort1.NewLine = "\r\n";     //回车换行。
            serialPort1.DataReceived +=
                new System.IO.Ports.SerialDataReceivedEventHandler
                (this.sComm_DataReceived);   //注册事件。
            serialPort1.PortName = cmPort.Text;
            serialPort1.BaudRate = int.Parse(cmBaudRate.Text);
            serialPort1.DataBits = 8;
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
            serialPort1.Open();
        }
        private void ClosePort()
        {
            if (serialPort1 != null)
            {
                //安全关闭当前串口。
                //注销串口中断接收事件，避免下次再执行进来，造成死锁。
                serialPort1.DataReceived -= this.sComm_DataReceived;
                serialPort1.Close();//现在没有死锁，可以关闭串口。
            }
        }
        #endregion
        #region Open and Close and Reset Settings 
        private void btOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenPort();
                if (serialPort1.IsOpen)
                {
                    btClose.Enabled = true;
                    btOpen.Enabled = false;
                    cmPort.Enabled = false;
                    cmBaudRate.Enabled = false;
                    tabCtrlMode.Enabled = true;
                    pickUpToolStripMenuItem.Enabled = true;
                    writeAndDrawToolStripMenuItem.Enabled = true;
                    visualDetetectionToolStripMenuItem.Enabled = true;
                    sendPacket(3, 0, dobot.origin_x, dobot.origin_y,dobot.origin_z, 0, 0,1, 0, 0);
                }
            }
            catch (Exception er)
            {
                ClosePort();
                MessageBox.Show("Open port failed!" + er.Message, "Dobot");                
            }
        }
      
        private void btClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                sendPacket(3, 0, dobot.origin_x, dobot.origin_y, dobot.origin_z, 0, 0, 1, 0, 0);
            ClosePort();
            if (!serialPort1.IsOpen)
            {
                btOpen.Enabled = true;
                btClose.Enabled = false;
                cmPort.Enabled = true;
                cmBaudRate.Enabled = true;
                tabCtrlMode.Enabled = false;
                dobot.init_Flag = false;
                pickUpToolStripMenuItem.Enabled = false;
                writeAndDrawToolStripMenuItem.Enabled = false;
                visualDetetectionToolStripMenuItem.Enabled = false;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            dobot.origin_x = retPacket.X;
            dobot.origin_y = retPacket.Y;
            dobot.origin_z = retPacket.Z;
            Thread.Sleep(500);
        }
        #endregion
        
        #region All TextBox Initialize
        private void InitializeTexts()
        {
            txtTargetX.Text = dobot.Target_x.ToString();
            txtTargetY.Text = dobot.Target_y.ToString();
            txtTargetZ.Text = dobot.Target_z.ToString();
            txtTargetJoint1.Text = dobot.Target_Joint1.ToString();
            txtTargetJoint2.Text = dobot.Target_Joint2.ToString();
            txtTargetJoint3.Text = dobot.Target_Joint3.ToString();
            txtTargetRotation.Text = dobot.Target_Rotation.ToString();
            txtTargetGripper.Text = dobot.Target_Gripper.ToString();
            chkTargetisGrab.Checked = Convert.ToBoolean(dobot.Target_isGrab);
            txtTargetJointSpeed.Text = dobot.Target_JointSpeed.ToString();
            txtTargetJointAcc.Text = dobot.Target_JointAcc.ToString();
            txtTargetServoSpeed.Text = dobot.Target_ServoSpeed.ToString();
            txtTargetServoAcc.Text = dobot.Target_ServoAcc.ToString();
            txtTargetLinearSpeed.Text = dobot.Target_LinearSpeed.ToString();
            txtTargetLinearAcc.Text = dobot.Target_LinearAcc.ToString();
            txtTargetJmpHeight.Text = dobot.Target_JmpHeight.ToString();
            txtTargetPauseTime.Text = dobot.Target_PauseTime.ToString();
            txtTargetLinearAcc.Text = dobot.Target_LinearAcc.ToString();
            txtTargetMovSpeedPercent.Text = dobot.Target_MovSpeedPercent.ToString();
            txtTargetMovAccPercent.Text = dobot.Target_MovAccPercent.ToString();
            txtJog_MaxSpeedPercent.Text = dobot.Jog_MaxSpeedPercent.ToString();
            txtJog_JointSpeed.Text = dobot.Jog_JointSpeed.ToString();
            txtJog_JointAcc.Text = dobot.Jog_JointAcc.ToString();
            txtJog_ServoSpeed.Text = dobot.Jog_ServoSpeed.ToString();
            txtJog_ServoAcc.Text = dobot.Jog_ServoAcc.ToString();
            txtJog_LinearSpeed.Text = dobot.Jog_LinearSpeed.ToString();
            txtJog_LinearAcc.Text = dobot.Jog_LinearAcc.ToString();
            txtMousedx.Text = dobot.Mouse_dx.ToString();
            txtMousedy.Text = dobot.Mouse_dy.ToString();
            txtMousedz.Text = dobot.Mouse_dz.ToString();
            txtMouseRotation.Text = dobot.Mouse_Rotation.ToString();
            chkMouseisGrab.Checked = Convert.ToBoolean(dobot.Mouse_isGrab);
            txtWriteLaserdx.Text = dobot.WriteLaser_dx.ToString();
            txtWriteLaserdy.Text = dobot.WriteLaser_dy.ToString();
            txtWriteLaserdz.Text = dobot.WriteLaser_dz.ToString();
            txtWriteLaserInitSpeed.Text = dobot.WriteLaser_initSpeed.ToString();
            txtWriteLaserFinalSpeed.Text = dobot.WriteLaser_finalSpeed.ToString();
            txtWriteLaserMaxSpeed.Text = dobot.WriteLaser_MaxSpeed.ToString();
            txtWriteLaserWritingAcc.Text = dobot.WriteLaser_WrittingAcc.ToString();
        }
        #endregion

        #region Packet Mode Config
        /*********************Packet Mode*********************************/
        private void btnPacketSend_Click(object sender, EventArgs e)
        {
            sendPacket(textBox1.Text, textBox2.Text, textBox3.Text,
                textBox4.Text, textBox5.Text, textBox6.Text,
                textBox7.Text, textBox8.Text, textBox9.Text,
                textBox10.Text);
        }
        #endregion
        #region Relative Mode Config
        /*********************Relative Mode*******************************/
        private void btnRelativeMoveSend_Click(object sender, EventArgs e)
        {
            if (chkMouseisGrab.Checked) dobot.Mouse_isGrab = 1;
            else dobot.Mouse_isGrab = 0;
            sendPacket("1", "0", txtMousedy.Text, txtMousedx.Text,
                txtMousedz.Text, txtMouseRotation.Text,
                dobot.Mouse_isGrab.ToString(), "0", "0", "0");
        }
        #endregion
        #region Target Mode Config
        /*********************Target Mode*******************************/
        private void chkAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdvanced.Checked == true)
                grpAdvanced.Enabled = true;
            else
                grpAdvanced.Enabled = false;
        }

        private void btnTargetDataSend_Click(object sender, EventArgs e)
        {
            if (rbtnJump.Checked) dobot.Target_MovStyle = 0;
            if (rbtnMovl.Checked) dobot.Target_MovStyle = 1;
            if (rbtnMovj.Checked) dobot.Target_MovStyle = 2;

            if (chkTargetisGrab.Checked)
                dobot.Target_isGrab = 1;
            else
                dobot.Target_isGrab = 0;

            sendPacket(dobot.Target_State.ToString(), "0", txtTargetX.Text,
                txtTargetY.Text,
                (Convert.ToSingle(txtTargetZ.Text)).ToString(),
                txtTargetRotation.Text,
                dobot.Target_isGrab.ToString(), dobot.Target_MovStyle.ToString(),
                txtTargetGripper.Text, txtTargetPauseTime.Text);
        }
        private void btnTargetConfigSend_Click(object sender, EventArgs e)
        {           
            sendPacket("9", "1", txtTargetJointSpeed.Text,
                txtTargetJointAcc.Text, txtTargetServoSpeed.Text, txtTargetServoAcc.Text,
                txtTargetLinearSpeed.Text, txtTargetLinearAcc.Text,
                txtTargetPauseTime.Text, txtTargetJmpHeight.Text);
            sendPacket("10", "0", txtTargetMovAccPercent.Text, txtTargetMovSpeedPercent.Text,
                dobot.Jog_MaxSpeedPercent.ToString(), "0", "0", "0", "0", "0");

            dobot.Target_PauseTime = Convert.ToSingle(txtTargetPauseTime.Text);
            dobot.Target_MovAccPercent = Convert.ToSingle(txtTargetMovAccPercent.Text);
            dobot.Target_MovSpeedPercent = Convert.ToSingle(txtTargetMovSpeedPercent.Text);
            dobot.Target_LinearAcc = Convert.ToSingle(txtTargetLinearAcc.Text);
            dobot.Target_LinearSpeed = Convert.ToSingle(txtTargetLinearSpeed.Text);
            dobot.Target_JointAcc = Convert.ToSingle(txtTargetJointAcc.Text);
            dobot.Target_JointSpeed = Convert.ToSingle(txtTargetJointSpeed.Text);
            dobot.Target_ServoAcc = Convert.ToSingle(txtTargetServoAcc.Text);
            dobot.Target_ServoSpeed = Convert.ToSingle(txtTargetServoSpeed.Text);
        }
       
        #endregion
        #region Writing or Laser Mode Config
        /*********************Writing or Laser Mode*******************************/
        private void btnWriteLaserSend_Click(object sender, EventArgs e)
        {
            sendPacket("4", dobot.WriteLaser_writingORlaser.ToString(),
                txtWriteLaserdx.Text, txtWriteLaserdy.Text,
                txtWriteLaserdz.Text, "0", dobot.WriteLaser_isLaser.ToString(),
                txtWriteLaserInitSpeed.Text,
                txtWriteLaserFinalSpeed.Text, txtWriteLaserMaxSpeed.Text);
            sendPacket("9","2", txtWriteLaserWritingAcc.Text,
                "0", "0", "0", "0", "0", "0", "0");
            dobot.WriteLaser_finalSpeed= Convert.ToSingle(txtWriteLaserFinalSpeed.Text); 
            dobot.WriteLaser_initSpeed = Convert.ToSingle(txtWriteLaserInitSpeed.Text);
            dobot.WriteLaser_MaxSpeed= Convert.ToSingle(txtWriteLaserMaxSpeed.Text);
            dobot.WriteLaser_WrittingAcc= Convert.ToSingle(txtWriteLaserWritingAcc.Text);
        }
        private void rbtnWLLaser_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnWLLaser.Checked)
            {
                dobot.WriteLaser_writingORlaser = 1;
                chkWLLaserOn.Enabled = true;
            }
            else
            {
                dobot.WriteLaser_writingORlaser = 0;
                chkWLLaserOn.Enabled = false;
            }
        }
        private void chkWLLaserOn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWLLaserOn.Checked)
                dobot.WriteLaser_isLaser = 1;
            else
                dobot.WriteLaser_isLaser = 0;
        }
        #endregion
        #region Joging Mode Config
        /*********************Joging Mode*******************************/
        private void btnJogConfigSend_Click(object sender, EventArgs e)
        {
            
            sendPacket("2","0", "0", "0", "0", "0", "0", 
                txtJog_MaxSpeedPercent.Text,"0","0");
            sendPacket("9","0", txtJog_JointSpeed.Text,txtJog_JointAcc.Text,
                txtJog_ServoSpeed.Text, txtJog_ServoAcc.Text,
                txtJog_LinearSpeed.Text,txtJog_LinearAcc.Text,"0","0");
            dobot.Jog_JointAcc = Convert.ToSingle(txtJog_JointAcc.Text);
            dobot.Jog_JointSpeed = Convert.ToSingle(txtJog_JointSpeed.Text);
            dobot.Jog_LinearAcc = Convert.ToSingle(txtJog_LinearAcc.Text);
            dobot.Jog_LinearSpeed = Convert.ToSingle(txtJog_LinearSpeed.Text);
            dobot.Jog_MaxSpeedPercent = Convert.ToSingle(txtJog_MaxSpeedPercent.Text);
            dobot.Jog_ServoSpeed = Convert.ToSingle(txtJog_ServoSpeed.Text);
            dobot.Jog_ServoAcc = Convert.ToSingle(txtJog_ServoAcc.Text);
        }
        private void btnJogXPlus_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(),"1","0","0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text,"0","0");
        }
        private void btnJogXPlus_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogXMinus_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "2", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogXMinus_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogYPlus_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "3", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogYPlus_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogYMinus_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "4", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogYMinus_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogZPlus_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "5", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogZPlus_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogZMinus_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "6", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogZMinus_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogRPlus_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "7", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogRPlus_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogRMinus_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "8", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogRMinus_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogGrabOn_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "9", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogGrabOn_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogGrabOff_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "10", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogGrabOff_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogGripperPlus_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "11", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogGripperPlus_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogGripperMinus_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "12", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogGripperMinus_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogLaserOn_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "13", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogLaserOn_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogLaserOff_MouseDown(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "14", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        private void btnJogLaserOff_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(dobot.Jog_State.ToString(), "0", "0", "0", "0", "0", "0",
                txtJog_MaxSpeedPercent.Text, "0", "0");
        }
        #endregion

        #region ToolStrip Menu Events
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.dobot.cc/");
        }
        private void visualDetetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualDetetectionToolStripMenuItem.Enabled = false;
            this.Hide();
            if (visualDetection == null)
            {
                visualDetection = new frmVisualDetection(this);
                visualDetection.Show();
            }
            else
            {
                visualDetection.Activate();
            }
        }
        private void writeAndDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WriteDraw == null)
            {
                WriteDraw = new frmWriteDraw(this, this.visualDetection);
                WriteDraw.Show();
            }
            else
            {
                WriteDraw.Activate();
            }
        }

        private void pickUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PickUp == null)
            {
                PickUp = new frmPickUp(this);
                PickUp.Show();
            }
            else
            {
                PickUp.Activate();
            }
        }
        #endregion
        #region RadioButtoms Event Config
        private void rbtnGrab_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            if (rbtn.Checked)
            {
                chkMouseisGrab.Enabled = true;
                chkTargetisGrab.Enabled = true;
                grpJogGrab.Enabled = true;
                grpJogGripper.Enabled = false;
                grpJogLaser.Enabled = false;
                grpWLWritingOrLaser.Enabled = false;
                txtTargetGripper.Enabled = false;
                dobot.Config_effectorSettings = 0;
                sendPacket("9", "4", dobot.Config_effectorSettings.ToString(),
                    "0", "0", "0", "0", "0", "0", "0");
            }
        }
        private void rbtnGripper_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            if (rbtn.Checked)
            {
                chkMouseisGrab.Enabled = false;
                chkTargetisGrab.Enabled = false;
                grpJogGrab.Enabled = false;
                grpJogGripper.Enabled = true;
                grpJogLaser.Enabled = false;
                grpWLWritingOrLaser.Enabled = false;
                txtTargetGripper.Enabled = true;
                dobot.Config_effectorSettings = 1;
                sendPacket("9", "4", dobot.Config_effectorSettings.ToString(),
                    "0", "0", "0", "0", "0", "0", "0");
            }
        }
        private void rbtnLaser_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            if (rbtn.Checked)
            {
                chkMouseisGrab.Enabled = false;
                chkTargetisGrab.Enabled = false;
                grpJogGrab.Enabled = false;
                grpJogGripper.Enabled = false;
                grpJogLaser.Enabled = true;
                txtTargetGripper.Enabled = false;
                grpWLWritingOrLaser.Enabled = true;
                dobot.Config_effectorSettings = 2;
                sendPacket("9", "4", dobot.Config_effectorSettings.ToString(),
                    "0", "0", "0", "0", "0", "0", "0");
            }
        }
        private void rbtnLinear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLinear.Checked)
            {
                dobot.Jog_State = 7;
                dobot.Target_State = 3;
                grpTargetLinearMode.Text = "Linear Mode";
                lblJogX.Text = "X:";
                lblJogY.Text = "Y:";
                lblJogZ.Text = "Z:";
            }
            else
            {
                dobot.Jog_State = 2;
                dobot.Target_State = 6;
                grpTargetLinearMode.Text = "Joint Mode";
                lblJogX.Text = "Joint1:";
                lblJogY.Text = "Joint2:";
                lblJogZ.Text = "Joint3:";
            }
        }
        private void rbtnJoint_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJoint.Checked == true)
            {
                grpTargetJointMode.Enabled = true;
                grpTargetLinearMode.Enabled = false;
            }
            else
            {
                grpTargetJointMode.Enabled = false;
                grpTargetLinearMode.Enabled = true;
            }
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    this.lblRetX.Text = retPacket.X.ToString();
                    this.lblRetY.Text = retPacket.Y.ToString();
                    this.lblRetZ.Text = retPacket.Z.ToString();
                    this.lblRetrHand.Text = retPacket.rHead.ToString();
                    this.lblRetbaseAngle.Text = retPacket.baseAngle.ToString();
                    this.lblRetlongArmAngle.Text = retPacket.longArmAngle.ToString();
                    this.lblRetshortArmAngle.Text = retPacket.shortArmAngle.ToString();
                    this.lblRetpawArmAngle.Text = retPacket.pawArmAngle.ToString();
                    this.lblRetisGrab.Text = retPacket.isGrab.ToString();
                    this.lblRetgripperAngle.Text = retPacket.GripperAngle.ToString();
                    this.lblOriginX.Text = "X: " + (retPacket.X - dobot.origin_x).ToString();
                    this.lblOriginY.Text = "Y: " + (retPacket.Y - dobot.origin_y).ToString();
                    this.lblOriginZ.Text = "Z: " + (retPacket.Z - dobot.origin_z).ToString();
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("Timing errors!" + Err.Message, "Dobot");
                timer1.Enabled = false;
            }
        }
        private void frmDobot_FormClosing(object sender, FormClosingEventArgs e)
        {
            btClose_Click(null, null);
        }
    }
}
