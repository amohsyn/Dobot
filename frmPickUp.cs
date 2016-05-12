using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobot
{
    public partial class frmPickUp : Form
    {
        private frmDobot Tranceiver;
        Thread pointCompare;
        private List<PickUpPoint> pointSeries = new List<PickUpPoint>();
        private Point pt = new Point(0, 0);
        private Point pt_last = new Point(0, 0);
        private bool picPickUp_RightClick_Count = false;
        private int isGrab = 0;
        private int movstyle = 1;
        public frmPickUp(frmDobot Tranceiver)
        {
            InitializeComponent();
            this.Tranceiver = Tranceiver;
        }   

        private void picPickUp_MouseClick(object sender, MouseEventArgs e)
        {
            int y = e.X * 2 - picPickUp.Size.Width;
            int x = e.Y * 2 - picPickUp.Size.Height;

            if (Math.Pow(y, 2) + Math.Pow(x, 2) < 16900 || Math.Pow(y, 2) + Math.Pow(x, 2) > 100489)
            {
                MessageBox.Show("不可达到的位置！");
                return;
            }
            //判断是否右键按下
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                picPickUp_RightClick_Count = !picPickUp_RightClick_Count;
                if (picPickUp_RightClick_Count)
                {
                    isGrab = 1;
                }
                else
                    isGrab = 0;
            }
            txtPickUpY.Text += y.ToString() + "\r\n";
            txtPickUpX.Text += x.ToString() + "\r\n";
            PickUpPoint pickUpPoint = new PickUpPoint(x, y, isGrab, movstyle);
            pointSeries.Add(pickUpPoint);
            int num = pointSeries.Count;
            if (num > 0)//允许对点序列操作
            {
                btnPickUpDelete.Enabled = true;
                btnPickUpClear.Enabled = true;
                btnPickUpSend.Enabled = true;
            }
            //绘制点
            Pen newPen = new Pen(Color.Black, 1);
            Graphics g = ((PictureBox)sender).CreateGraphics();
            if (num == 1)//第一个点为红色的大点
                g.FillEllipse(Brushes.Red, e.X - 5, e.Y - 5, 10, 10);
            else
                g.FillEllipse(Brushes.Blue, e.X - 2, e.Y - 2, 5, 5);
            pt.X = e.X;
            pt.Y = e.Y;
            if (num > 1)
            {
                g.DrawLine(newPen, pt, pt_last);
            }
            pt_last = pt;
            g.Dispose();
            newPen.Dispose();
        }

        private void btnPickUpSend_Click(object sender, EventArgs e)
        {
            pointCompare = new Thread(new ParameterizedThreadStart(pointSeriesCompare));
            pointCompare.Start(pointSeries);
        }

        private void pointSeriesCompare(object pup)
        {
            List<PickUpPoint> pointSeries = (List<PickUpPoint>)pup;
            for (int i = 0; i < pointSeries.Count; i++)
            {
                if (i == 0)
                    if (pointSeries[i].isGrab == 1)
                        pointSeries[i].MovStyle = 0;
                if (i > 0)
                {
                    if (Convert.ToBoolean(pointSeries[i].isGrab) ^
                        Convert.ToBoolean(pointSeries[i - 1].isGrab))
                        pointSeries[i].MovStyle = 0;

                    while (true)
                    {
                        if (Math.Abs(Tranceiver.retPacket.X - pointSeries[i - 1].X) < 0.1 &&
                            Math.Abs(Tranceiver.retPacket.Y - pointSeries[i - 1].Y) < 0.1)
                            break;
                    }
                }
                Tranceiver.sendPacket(3, 0,pointSeries[i].X,pointSeries[i].Y,
                    Convert.ToSingle(txtHeight.Text) + dobot.origin_z,
                    0, pointSeries[i].isGrab, pointSeries[i].MovStyle,0, dobot.Target_PauseTime);
            }
            Tranceiver.sendPacket("3", "0", dobot.origin_x.ToString(),dobot.origin_y.ToString(),
                    dobot.origin_z.ToString(), "0", "0", "0", "0", "0");
            pointCompare.Abort();
        }
        private void picPickUp_MouseMove(object sender, MouseEventArgs e)
        {
            lblPickUpMoveY.Text = "Y :" + (e.X * 2 - picPickUp.Size.Width).ToString();
            lblPickUpMoveX.Text = "X :" + (e.Y * 2 - picPickUp.Size.Height).ToString();
            int y = e.X * 2 - picPickUp.Size.Width;
            int x = e.Y * 2 - picPickUp.Size.Height;
            if (Math.Pow(y, 2) + Math.Pow(x, 2) < 16900 || Math.Pow(y, 2) + Math.Pow(x, 2) > 100489)
            {
                lblPickUpMoveX.ForeColor = System.Drawing.Color.Red;
                lblPickUpMoveY.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblPickUpMoveX.ForeColor = System.Drawing.Color.Black;
                lblPickUpMoveY.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void picPickUp_MouseLeave(object sender, EventArgs e)
        {
            lblPickUpMoveY.Text = "Y :";
            lblPickUpMoveX.Text = "X :";
        }
        private void btnPickUpDelete_Click(object sender, EventArgs e)
        {
            int num = pointSeries.Count;
            pointSeries.RemoveAt(num - 1);
            int rowTxt = txtPickUpX.Lines.Length - 1;
            picPickUp.Invalidate();//自动调用paint事件//picPickUp_Paint(null,null);
            if (num == 1)
            {
                txtPickUpX.Text = "";
                txtPickUpY.Text = "";
                btnPickUpDelete.Enabled = false;
                btnPickUpClear.Enabled = false;
                btnPickUpSend.Enabled = false;
            }
            else
            {
                int index_txtX = txtPickUpX.GetFirstCharIndexFromLine(rowTxt - 1);
                int index_txtY = txtPickUpY.GetFirstCharIndexFromLine(rowTxt - 1);
                txtPickUpX.Text = txtPickUpX.Text.Substring(0, index_txtX - 1);
                txtPickUpY.Text = txtPickUpY.Text.Substring(0, index_txtY - 1);
            }
        }
        private void btnPickUpClear_Click(object sender, EventArgs e)
        {
            txtPickUpX.Text = "";
            txtPickUpY.Text = "";
            btnPickUpDelete.Enabled = false;
            btnPickUpClear.Enabled = false;
            btnPickUpSend.Enabled = false;
            pointSeries.Clear();
            picPickUp.Invalidate();
        }
        private void btnPickUpReverse_Click(object sender, EventArgs e)
        {
            pointSeries.Reverse();
            btnPickUpSend_Click(null, null);
        }

        private void picPickUp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < pointSeries.Count; i++)
            {
                int x = (pointSeries[i].Y + picPickUp.Size.Width) / 2;
                int y = (pointSeries[i].X + picPickUp.Size.Height) / 2;
                if (i == 0)
                    g.FillEllipse(Brushes.Red, x - 5, y - 5, 10, 10);
                else
                {
                    int x_last = (pointSeries[i - 1].Y + picPickUp.Size.Width) / 2;
                    int y_last = (pointSeries[i - 1].X + picPickUp.Size.Width) / 2;
                    g.FillEllipse(Brushes.Blue, x - 2, y - 2, 5, 5);
                    Pen newPen = new Pen(Color.Black, 1);
                    g.DrawLine(newPen, x, y, x_last, y_last);
                }
            }
        }
    }
    class PickUpPoint
    {
        public int X;
        public int Y;
        public int isGrab;
        public int MovStyle = 1;

        public PickUpPoint(int x, int y, int isGrab, int MovStyle)
        {
            this.X = x;
            this.Y = y;
            this.isGrab = isGrab;
            this.MovStyle = MovStyle;
        }
    }
}
