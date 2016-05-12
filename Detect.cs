using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Dobot
{
    public partial class frmVisualDetection
    {
        int HoughDetectInterval = 100;
        bool HoughGotFlag = false;
        private Point matchTemple(Mat src, Mat temple, TemplateMatchingType type, Mat dest)
        {
            Mat srcCopy = new Mat();
            Point center = new Point();
            Point matchLoc = new Point();
            double minVal = new double(); double maxVal = 0;
            Point minLoc = new Point(); Point maxLoc = new Point();            
            CvInvoke.CvtColor(src, srcCopy, ColorConversion.Bgr2Gray);
            Mat MatchResult = new Mat(srcCopy.Rows - temple.Rows + 1, srcCopy.Cols - temple.Cols + 1, DepthType.Cv32F, 1);
            CvInvoke.MatchTemplate(srcCopy, temple, MatchResult, type);
            CvInvoke.MinMaxLoc(MatchResult, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
            if (type == TemplateMatchingType.SqdiffNormed ||
                type == TemplateMatchingType.Sqdiff)
                matchLoc = minLoc;
            else
                matchLoc = maxLoc;
            Rectangle MatchRect = new Rectangle(matchLoc, temple.Size);
            CvInvoke.Rectangle(dest, MatchRect, new Bgr(Color.Red).MCvScalar);
            center.X = matchLoc.X + temple.Width/2;
            center.Y = matchLoc.Y + temple.Height/2;
            imageBox9.Image = temple;
            //imageBox10.Image = dest;
            return center;
        }
        private void HoughProcess(Mat src, Mat dest, RoundBlock roundblock)
        {
            Mat srcCopy = new Mat();
            CvInvoke.CvtColor(src, srcCopy, ColorConversion.Bgr2Gray);
            double cannyThreshold = 180.0;
            double circleAccumulatorThreshold = 120;
            CircleF[] circle = CvInvoke.HoughCircles(srcCopy, HoughType.Gradient,
                2.0, 20.0, cannyThreshold, circleAccumulatorThreshold, 5);
            //Mat circleImage = new Mat(dest.Size, DepthType.Cv8U, 3);
            //circleImage.SetTo(new MCvScalar(0));
           // Mat circleimage = new Mat();
            if (circle.Length > 0)
            {
                CvInvoke.Circle(dest, Point.Round(circle[0].Center),
                    (int)circle[0].Radius, new Bgr(Color.White).MCvScalar, 2);
                roundblock.ROI = new Rectangle((int)(circle[0].Center.X - circle[0].Radius),
                (int)(circle[0].Center.Y - circle[0].Radius),
                    2 * (int)(circle[0].Radius),
                    2 * (int)(circle[0].Radius));
                roundblock.image = new Mat(srcCopy, roundblock.ROI);
                roundblock.BlockCenterInImage = Point.Round( circle[0].Center);
                roundblock.BlockCenter = environment.axis_Dobot2User(roundblock.BlockCenterInImage);
                HoughGotFlag = true;
            }
        }
        private Point meanshift(Mat src,Rectangle ROI, out Mat dest, out Rectangle newROI)
        {
            dest = src.Clone();
            newROI = myMeanShift.MeanShift(src.ToImage<Bgr, byte>(), dest.ToImage<Bgr, byte>(), ROI, minSat);
            Point center = new Point(ROI.X + ROI.Width / 2, ROI.Y + ROI.Height / 2);
            CvInvoke.Rectangle(dest, newROI, new Bgr(Color.Green).MCvScalar);
            return center;
        }
        
        private Mat thresholdProcess(Mat src,int threshold)
        {
            Mat dst = new Mat();
            CvInvoke.CvtColor(src, dst, ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(dst, dst, threshold, 255, ThresholdType.Binary);
            return dst;
        }

    }
}
