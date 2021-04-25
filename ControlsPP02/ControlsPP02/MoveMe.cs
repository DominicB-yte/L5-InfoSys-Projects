using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsPP02
{
    public partial class MoveMe : Form
    {
        public MoveMe()
        {
            InitializeComponent();
        }

        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            lblMove.Left = 0;
            lblMove.Top = 0;
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            lblMove.Left = 200;
            lblMove.Top = 0;
        }

        private void btnBottomLeft_Click(object sender, EventArgs e)
        {
            lblMove.Left = 0;
            lblMove.Top = 200;
        }

        private void btnBottomRight_Click(object sender, EventArgs e)
        {
            lblMove.Left = 200;
            lblMove.Top = 200;
        }
    }
}
