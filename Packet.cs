using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dobot 
{  
    internal class Packet
    {
        public float X =0;
        public float Y =0;
        public float Z =0;
        public float rHead =0;
        public float baseAngle =0;
        public float longArmAngle =0;
        public float shortArmAngle =0;
        public float pawArmAngle =0;
        public float isGrab =0;
        public float GripperAngle =0;       
    }
    class WritePacket
    {
        public string flt1 = "0";
        public string flt2 = "0";
        public string flt3 = "0";
        public string flt4 = "0";
        public string flt5 = "0";
        public string flt6 = "0";
        public string flt7 = "0";
        public string flt8 = "0";
        public string flt9 = "0";
        public string flt10= "0";
        public WritePacket() { }
    }    

    public static class dobot
    {
        public static bool init_Flag = true;//判断第一次接受数据的标志
        public static float origin_x ;
        public static float origin_y ;
        public static float origin_z ;

        public static  float Mouse_dx=0;
        public static  float Mouse_dy=0;
        public static  float Mouse_dz=0;
        public static  float Mouse_Rotation=0;
        public static float Mouse_isGrab=0;

        public static float Jog_State = 7;//Linear->7  Joint->2
        public static float Jog_MaxSpeedPercent = 100;//1%-100%
        public static float Jog_JointSpeed = 350;//     °/s
        public static float Jog_JointAcc = 250;//       °/s²
        public static float Jog_ServoSpeed = 30;//     °/s
        public static float Jog_ServoAcc = 50;//       °/s²
        public static float Jog_LinearSpeed = 100;//    mm/s
        public static float Jog_LinearAcc = 200;//      mm/s²

        public static float Target_State = 3;//Linear->3   Joint->6
        public static float Target_x=170;
        public static float Target_y=0;
        public static float Target_z=-30;
        public static float Target_Rotation=0;
        public static float Target_Joint1=0;
        public static float Target_Joint2=0;
        public static float Target_Joint3=0;
        public static float Target_isGrab=0;      //0,1
        public static float Target_MovStyle=0;     //0->Jmp 1->MovL 2->MovJ
        public static float Target_Gripper=0;      //-90-90
        public static float Target_PauseTime=0.5f;     //s
        public static float Target_JointSpeed=200;     //°/s
        public static float Target_JointAcc = 200;     //°/s²
        public static float Target_ServoSpeed = 200;   //°/s
        public static float Target_ServoAcc = 200;     //°/s²
        public static float Target_LinearSpeed=200;    //mm/s
        public static float Target_LinearAcc = 400;    //mm/s²
        public static float Target_JmpHeight = 20;     //mm
        public static float Target_MovSpeedPercent = 100;  //1%-100%
        public static float Target_MovAccPercent = 100;    //1%-100%

        public static float WriteLaser_dx=0;
        public static float WriteLaser_dy=0;
        public static float WriteLaser_dz=0;
        public static float WriteLaser_writingORlaser=0;//writing ->0  laser->1
        public static float WriteLaser_isLaser=0;
        public static float WriteLaser_initSpeed=2;
        public static float WriteLaser_finalSpeed=2;
        public static float WriteLaser_MaxSpeed=2;
        public static float WriteLaser_WrittingAcc = 0.02f;//

        public static float Config_effectorSettings=0;//0->grab 1->gripper 2->Laser
        public static float Config_ManuJoint2InitAngle=0;
        public static float Config_ManuJoint3InitAngle=0;
    }
}
