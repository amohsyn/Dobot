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
    static class myMeanShift
    {
        public static Rectangle MeanShift(Mat src, Rectangle ROI)
        {
            Image<Hsv, Byte> HSVimage = src.ToImage<Hsv, Byte>();
            Image<Gray, Byte>[] HSVimages = HSVimage.Split();
            HSVimages[0].ROI = ROI;
            DenseHistogram HueHist = GetHistogram(HSVimages[0]);
            HSVimages[0].ROI = Rectangle.Empty;
            Image<Gray, Byte> result = HueHist.BackProject(new Image<Gray, Byte>[] { HSVimages[0] });
            CvInvoke.MeanShift(result, ref ROI, new MCvTermCriteria(10, 0.01));
            return ROI;
        }
        public static Rectangle MeanShift(Image<Bgr, Byte> sourceImage, Image<Bgr, Byte> targetImage, Rectangle ROI, int minSat)
        {
            //Convert to HSV color space
            Image<Hsv, Byte> HSVimage = sourceImage.Convert<Hsv, Byte>();
            Image<Hsv, Byte> HSVimage2 = targetImage.Convert<Hsv, Byte>();
            //Get Hue, Saturation, Value image
            Image<Gray, Byte>[] HSVimages = HSVimage.Split();
            Image<Gray, Byte>[] HSVimages2 = HSVimage2.Split();
            //Mask to be used
            Image<Gray, Byte> lowSatnMask = HSVimages[1].ThresholdBinary(new Gray(minSat), new Gray(255));
            //Set the ROI
            HSVimages[0].ROI = ROI;
            lowSatnMask.ROI = ROI;
            //Get the Hue histogram
            DenseHistogram HueHist = GetHistogram(HSVimages[0], lowSatnMask);
    //    imageBox1.Image = DrawHistImg(HueHist, 400, 200, Color.HotPink);
    //    imageBox2.Image = HSVimages[0];
    //    imageBox4.Image = HSVimages[1];
            //Reset the ROI
            HSVimages[0].ROI = Rectangle.Empty;
            lowSatnMask = HSVimages2[1].ThresholdBinary(new Gray(minSat), new Gray(255));
            //Get backprojection of Hue histogram
            Image<Gray, Byte> result = HueHist.BackProject(new Image<Gray, Byte>[] { HSVimages2[0] });
            //Eliminate low saturation pixels
            result._And(lowSatnMask);

            //MeanShift algorithm
            CvInvoke.MeanShift(result, ref ROI, new MCvTermCriteria(10, 0.01));
            //Get the result area
            return ROI;
        }

        public static DenseHistogram GetHistogram(Image<Gray, byte> image)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { image }, true, null);
            return hist;
        }
        public static DenseHistogram GetHistogram(Image<Gray, Byte> image, Image<Gray, Byte> mask)
        {
            //Create a histogram
            DenseHistogram histogram =
                new DenseHistogram(
                    //number of bins
                    256,
                     //pixel value range
                     new RangeF(0, 255)
                    );
            Image<Gray, byte>[] images = new Image<Gray, byte>[] { image };
            //Compute histogram
            histogram.Calculate(
                images, //Split current Image into an array of gray scale images
                true, //If it is true, the histogram is not cleared in the beginning
                mask  //no mask is used
                );
            return histogram;
        }
        public static Image<Bgr, byte> DrawHistImg(DenseHistogram hist, int width, int height, Color color)
        {
            double minV = 0;
            double maxV = 0;
            Point minL = new Point(0, 0);
            Point maxL = new Point(0, 0);
            int h_bins = hist.BinDimension[0];
            CvInvoke.MinMaxLoc(hist, ref minV, ref maxV, ref minL, ref maxL);
            Image<Bgr, byte> histImg = new Image<Bgr, byte>(width, height, new Bgr(Color.White));
            int bin_w = width / (h_bins);
            for (int i = 0; i < h_bins; i++)
            {
                double bin_Value = hist.GetBinValues()[i];
                int intensity = (int)Math.Round(bin_Value * height / maxV);  //要绘制的高度    
                //注意y左上角坐标，所以图像是反的。
                histImg.Draw(new Rectangle(i * bin_w, height - intensity, bin_w, intensity), new Bgr(color),
                    1, Emgu.CV.CvEnum.LineType.AntiAlias, 0);
            }
            return histImg;
        }
    }
}
