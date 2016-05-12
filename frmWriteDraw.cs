using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Util;

namespace Dobot
{
    public partial class frmWriteDraw : Form
    {
        frmDobot Tranceiver;
        
        public frmWriteDraw(frmDobot Tranceiver)
        {
            InitializeComponent();
            this.Tranceiver = Tranceiver;
        }
        private void getContour(Mat src)
        {
            CvInvoke.Blur(src, src,new Size(3,3),new Point(-1,-1));
            Mat cannyEdges = new Mat();
            
            CvInvoke.Threshold(src, cannyEdges, 100, 255, ThresholdType.Binary);
            CvInvoke.Canny(cannyEdges, cannyEdges, CannyThresh, 2 * CannyThresh);
            ibxImgShow.Image = cannyEdges;
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(cannyEdges, contours, null, 
                    RetrType.External, ChainApproxMethod.ChainApproxNone);
                int count = contours.Size;
                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    {
                        Console.WriteLine(contour.Size);
                    }
                }
                    
            }



        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int[][] que = new int[5][];
            for(int i = 0; i < 5; i++)
            {
                Tranceiver.sendPacket(4, 0, 2, 0, 0, 0, 0, 2, 2, 2);
            }
            
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                txtfileName.Text = openFileDialog1.FileName;
            }
        }

        private void txtfileName_TextChanged(object sender, EventArgs e)
        {
            string imgPath = ((TextBox)sender).Text;
            if (imgPath != String.Empty)
            {
                Console.WriteLine(imgPath);
                Image<Bgr, Byte> img = new Image<Bgr, byte>(imgPath).
                    Resize(600, 480,Inter.Cubic, true);
                Mat src = new Mat();
                CvInvoke.CvtColor(img, src, ColorConversion.Bgr2Gray);
                getContour(src);
            }
        }
        int CannyThresh=100;
        private void trbCannyThresh_Scroll(object sender, EventArgs e)
        {
            CannyThresh = ((TrackBar)sender).Value;
            lblCannyThresh.Text = "Canny Threshold: " + CannyThresh;
        }
    }
}
