using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dobot
{
    partial class frmDobot
    {
        /// <summary>
        /// 向Dobot发送10个数据长度的数据包，格式为string或者float
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <param name="d3"></param>
        /// <param name="d4"></param>
        /// <param name="d5"></param>
        /// <param name="d6"></param>
        /// <param name="d7"></param>
        /// <param name="d8"></param>
        /// <param name="d9"></param>
        /// <param name="d10"></param>
        internal void sendPacket(string d1, string d2, string d3,
            string d4, string d5, string d6, string d7,
            string d8, string d9, string d10)
        {
            //Console.WriteLine("Send:"+Thread.CurrentThread.ManagedThreadId);

            sendData("a5");
            sendFltAsStr(d1);
            sendFltAsStr(d2);
            sendFltAsStr(d3);
            sendFltAsStr(d4);
            sendFltAsStr(d5);
            sendFltAsStr(d6);
            sendFltAsStr(d7);
            sendFltAsStr(d8);
            sendFltAsStr(d9);
            sendFltAsStr(d10);
            sendData("5a");
        }
        internal void sendPacket(float d1, float d2, float d3,
            float d4, float d5, float d6, float d7,
            float d8, float d9, float d10)
        {
            //Console.WriteLine("Send:"+Thread.CurrentThread.ManagedThreadId);

            sendData("a5");
            sendFltAsStr(d1.ToString());
            sendFltAsStr(d2.ToString());
            sendFltAsStr(d3.ToString());
            sendFltAsStr(d4.ToString());
            sendFltAsStr(d5.ToString());
            sendFltAsStr(d6.ToString());
            sendFltAsStr(d7.ToString());
            sendFltAsStr(d8.ToString());
            sendFltAsStr(d9.ToString());
            sendFltAsStr(d10.ToString());
            sendData("5a");
        }
        internal void sendPacket(WritePacket wp)
        {
            sendPacket(wp.flt1, wp.flt2, wp.flt3,
            wp.flt4, wp.flt5, wp.flt6, wp.flt7,
            wp.flt8, wp.flt9, wp.flt10);
        }
        /// <summary>
        /// 将string参数转为float，并转成4个字节的byte数组，
        /// 调用sendData(string input)，发送数据。
        /// 例如：参数value="13.2"
        /// </summary>
        /// <param name="value"></param>
        public void sendFltAsStr(string value)
        {
            try
            {
                float a = 0;
                a = Convert.ToSingle(value);
                //float a=float.Parse(value);
                byte[] mybyte = new byte[4];
                mybyte = BitConverter.GetBytes(a);
                for (int i = 0; i < mybyte.Length; i++)
                    sendData(mybyte[i].ToString("x"));
            }
            catch(FormatException)
            {
                MessageBox.Show("Format");
            }
        }
        public void sendData(string input)
        {
            try
            {
                if (!serialPort1.IsOpen)
                    btOpen_Click(null, null);
                string TempStr = string.Empty;
                TempStr = input;
                TempStr = DelSpace(TempStr);
                SendAsHex(TempStr);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Dobot");
                
            }
        }
        public void SendAsHex(string str)
        {
            int Len = str.Length;
            byte[] send = new byte[Len / 2];
            int j = 0;
            for (int i = 0; i < Len; i = i + 2, j++)
                send[j] = Convert.ToByte(str.Substring(i, 2), 16);
            serialPort1.Write(send, 0, send.Length);
        }

        public string DelSpace(string str)
        {
            string TempStr = string.Empty;
            int Len = str.Length;
            for (int i = 0; i < Len; i++)
            {
                if (str[i] != ' ')
                    TempStr += str[i];
            }
            Len = TempStr.Length;
            if (Len % 2 != 0)
                TempStr = '0' + TempStr;
            return TempStr;
        }
    }
}
