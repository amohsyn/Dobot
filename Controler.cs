using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobot
{
    class Controler
    {
        private RoundBlock CtrledPlant;
        private Environment environment;
        private frmDobot tranceiver;
        private float[] Error=new float[2];
        private float[] preError = new float[2];
        private float[] Acc = new float[2];
        private float[] prepreError = new float[2];//not use
        private float[] errorSum = new float[2] { 0,0};
        public  float[] Output = new float[2];
        private bool[] SignCross = new bool[2];
        private PointF loc_Target = new PointF();
        private PointF loc_Executor = new PointF();
        private PointF trackTarget = new PointF();

        public bool enable=false;
        public  float delta_T=60;
        public  float Kp=1;
        public  float Ki=0;
        public  float Kd=0;

        private int targetSendCount = 0;
        public int sendInterval = 1;
        public float TargetDeadzone=8;
        public float JogDeadzone=1.1f;
        public float JogMaxSpeed = 370;
        public float JogMaxAcc = 270;
        public float K_JogSpeed= 0.1781f;
        public float Kd_JogSpeed= 0.2329f;
        public Controler(RoundBlock CtrledPlant,Environment environment, frmDobot tranceiver)
        {
            this.CtrledPlant = CtrledPlant;
            this.environment = environment;
            this.tranceiver = tranceiver;
        }
        private PointF calculatePID(PointF Target)//位置式 PD 
        {
            PointF result = new PointF();
            loc_Target = environment.axis_User2Dobot(Target);
            loc_Executor.X= tranceiver.retPacket.X;
            loc_Executor.Y= tranceiver.retPacket.Y;
            Error[0] =( loc_Target.X - loc_Executor.X);
            Error[1] =( loc_Target.Y - loc_Executor.Y) / delta_T * 60;
            errorSum[0] += Error[0];
            errorSum[1] += Error[1];
            for (int i = 0; i < 2; i++)
            {
                Output[i] = Kp * Error[i] +Ki*errorSum[i] + Kd * (Error[i] - preError[i]);
                Acc[i] = Error[i] - preError[i];
                if ((Convert.ToBoolean(Math.Sign(Error[i]))) ^ (Convert.ToBoolean(Math.Sign(preError[i]))))
                    SignCross[i] = true;
                else
                    SignCross[i] = false;
            }           
            preError.CopyTo(prepreError, 0);
            Error.CopyTo(preError,0);
            result.X = Output[0] + loc_Executor.X;
            result.Y = Output[1] + loc_Executor.Y;
            //   return environment.axis_Dobot2Image(result);
            return result;//in dobot coordinate
        }

        public  void trackTargetSend(Point center)
        {
            PointF temp = environment.axis_Image2User(center);
            if (Math.Abs(temp.X - CtrledPlant.BlockCenter.X) > TargetDeadzone ||
                Math.Abs(temp.Y - CtrledPlant.BlockCenter.Y) > TargetDeadzone)
            {
                targetSendCount++;
                CtrledPlant.BlockCenter = temp;
                trackTarget.X = CtrledPlant.BlockCenter.X / 2;
                trackTarget.Y = CtrledPlant.BlockCenter.Y;
                PointF result = calculatePID(trackTarget);
                if (targetSendCount == sendInterval)
                {
                    targetSendCount = 0;
                    tranceiver.sendPacket(3, 0, dobot.origin_x, result.Y, CtrledPlant.Height + dobot.origin_z,
                        0, 0, 1, 0, 0);
                }
            }
        }
        public  void jogSend(PointF center,bool isY)
        {
            float error,acc;
            error = Error[Convert.ToInt16(isY)];//isY=1, then error=Error[1],Y
            acc = Acc[Convert.ToInt16(isY)];
            calculatePID(environment.axis_Image2Dobot(CtrledPlant.BlockCenterInImage));
            Console.WriteLine(CtrledPlant.BlockCenterInImage);
            if (Math.Abs(error) < JogDeadzone * 2f)
                tranceiver.sendPacket(2, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            else
            {
                float speed = Math.Abs(error * K_JogSpeed + acc * Kd_JogSpeed);
                if (speed > 250) speed = 250;
                if (speed < 1) speed = 1;
                if (SignCross[1])
                    tranceiver.sendPacket(2, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                if (error > 0)
                {
                    tranceiver.sendPacket(2, 1, 0, 0, 0, 0, 0, speed, 0, 0);
                }
                else
                {
                    tranceiver.sendPacket(2, 2, 0, 0, 0, 0, 0, speed, 0, 0);
                }
            }
        }

    }
}
