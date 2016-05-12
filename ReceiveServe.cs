using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Dobot
{
    partial class frmDobot
    {
        int stateMachine = 0;
        int t = 0;
        int fltCount = 0;
        public static byte rxBuf;
        public static int rxData;
        public static byte rxAdd;
        byte[] dataBuf = new byte[4];       
        float[] fltBuf = new float[10];//暂存收到的Return packet 中的10个float数据 
        private void sComm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                rxBuf = (byte)serialPort1.ReadByte();
                if (stateMachine == 0)
                {
                    if (rxBuf == 0x5a) stateMachine = 1;
                    else stateMachine = 0;
                }
                else if (stateMachine == 1)
                {
                    if (rxBuf == 0xa5) stateMachine = 2;
                    else stateMachine = 0;
                }
                else if (stateMachine == 2)
                {
                    dataBuf[t++] = rxBuf;
                    if (t > 3)  //receive 4 byte data
                    {
                        fltBuf[fltCount++] = BitConverter.ToSingle(dataBuf, 0);
                        t = 0;
                        if (fltCount == 10)
                        {
                            fltCount = 0;
                            retPacket.X = fltBuf[0];
                            retPacket.Y = fltBuf[1];
                            retPacket.Z = fltBuf[2];
                            retPacket.rHead = fltBuf[3];
                            retPacket.baseAngle = fltBuf[4];
                            retPacket.longArmAngle = fltBuf[5];
                            retPacket.shortArmAngle = fltBuf[6];
                            retPacket.pawArmAngle = fltBuf[7];
                            retPacket.isGrab = fltBuf[8];
                            retPacket.GripperAngle = fltBuf[9];
                            if(dobot.init_Flag)
                            {
                                dobot.init_Flag = false;
                                dobot.origin_x = retPacket.X;
                                dobot.origin_y = retPacket.Y;
                                dobot.origin_z = retPacket.Z;
                            }
                            serialPort1.DiscardInBuffer();//清空缓冲区
                            stateMachine = 0;
                        }
                    }
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Receiving Error!");
            }
        }
    }
}
