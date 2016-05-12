using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobot
{
    public partial class frmWriteDraw : Form
    {
        frmDobot father;
        frmVisualDetection brother1;
        public frmWriteDraw(frmDobot father, frmVisualDetection brother1)
        {
            InitializeComponent();
            this.father = father;
            this.brother1 = brother1;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int[][] que = new int[5][];
            for(int i = 0; i < 5; i++)
            {
                father.sendPacket(4, 0, 2, 0, 0, 0, 0, 2, 2, 2);
            }
            
        }
    }
}
