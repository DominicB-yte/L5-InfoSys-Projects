using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP04Classwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormatColourRedMenuItem_Click(object sender, EventArgs e)
        {
            textBoxContents.ForeColor = Color.Red;
        }

        private void FormatColourGreenMenuItem_Click(object sender, EventArgs e)
        {
            textBoxContents.ForeColor = Color.Green;
        }

        private void FormatColourBlueMenuItem_Click(object sender, EventArgs e)
        {
            textBoxContents.ForeColor = Color.Blue;
        }

        private void FormatBackColourPinkMenuItem_Click(object sender, EventArgs e)
        {
            textBoxContents.BackColor = Color.Pink;
        }

        private void FormatBackColourLGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxContents.BackColor = Color.LightGreen;
        }

        private void FormatBackColourLBlueMenuItem_Click(object sender, EventArgs e)
        {
            textBoxContents.BackColor = Color.LightBlue;
        }

        private void FormatFontSmallMenuItem_Click(object sender, EventArgs e)
        {
            textBoxContents.Font = FormatFontSmallMenuItem.Font;
        }

        private void FormatFontMediumMenuItem_Click(object sender, EventArgs e)
        {
            textBoxContents.Font = FormatFontMediumMenuItem.Font;
        }

        private void FormatFontLargeMenuItem_Click(object sender, EventArgs e)
        {
            textBoxContents.Font = FormatFontLargeMenuItem.Font;
        }
    }
}
