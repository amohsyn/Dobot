using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Windows.Forms;
using Emgu.CV.UI;

namespace Dobot
{
    internal class Environment
    {
        public  SizeF VisualField;// height=150(x)  width=200(y)
        public  Size ImageSize;//480*640
        public  PointF OriginXY_Dobot;//in Dobot coordinate
        public  PointF axis_Image2Dobot(Point point)
        {
            PointF result = new PointF();
            result.X = Convert.ToSingle(point.Y)
                * VisualField.Height / ImageSize.Height + OriginXY_Dobot.X;
            result.Y = Convert.ToSingle((point.X - ImageSize.Width / 2))
                * VisualField.Width / ImageSize.Width + OriginXY_Dobot.Y;
            return result;
        }
        public  Point axis_Dobot2Image(PointF pointf)
        {
            PointF result = new Point();
            result.Y = (pointf.X - OriginXY_Dobot.X) * ImageSize.Height / VisualField.Height;
            result.X = (pointf.Y - OriginXY_Dobot.Y) / VisualField.Width * ImageSize.Width + ImageSize.Width / 2;
            return Point.Round(result);
        }
        public  PointF axis_User2Dobot(PointF point)
        {
            PointF ret = new PointF();
            ret.X = point.X + OriginXY_Dobot.X;
            ret.Y = point.Y + OriginXY_Dobot.Y;
            return ret;
        }
        public  PointF axis_Dobot2User(PointF point)
        {
            PointF ret = new PointF();
            ret.X = point.X - OriginXY_Dobot.X;
            ret.Y = point.Y - OriginXY_Dobot.Y;
            return ret;
        }
        public  PointF axis_Image2User(Point point)
        {
            PointF result = new PointF();
            result.X = Convert.ToSingle(point.Y)
                * VisualField.Height / ImageSize.Height;
            result.Y = Convert.ToSingle((point.X - ImageSize.Width / 2))
                * VisualField.Width / ImageSize.Width;
            return result;
        }
        public Environment( SizeF VisualField, PointF OriginXY_Dobot)
        {
            this.VisualField = VisualField;
            this.OriginXY_Dobot = OriginXY_Dobot;
        }
        public Environment(float VisualFieldHeight, float VisualFieldWidth, float OriginX_Dobot, float OriginY_Dobot)
        {
            this.VisualField.Width = VisualFieldWidth;
            this.VisualField.Height = VisualFieldHeight;
            this.OriginXY_Dobot.X = OriginX_Dobot;
            this.OriginXY_Dobot.Y = OriginY_Dobot;
        }
    }
    class RoundBlock
    {
        public Mat image;
        public PointF BlockCenter;//in user coordinate
        public Point BlockCenterInImage;//in image coordinate
        public float Height = 0;//roundBlock Height
        public Rectangle ROI;//in image coordinate
    }

}

