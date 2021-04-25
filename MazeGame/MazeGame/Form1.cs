using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cursor.Position = labelStart.PointToScreen(Point.Empty);
            //this.Cursor = new Cursor(GetType(), "Cursor1.Cur");
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Position = labelStart.PointToScreen(Point.Empty);
        }

        private void labelKey1_MouseMove(object sender, MouseEventArgs e)
        {
            labelDoor1.Controls.Remove(labelDoor1);
            labelDoor1.Dispose();
            labelKey1.Controls.Remove(labelKey1);
            labelKey1.Dispose();
        }

        private void labelKey2_MouseMove(object sender, MouseEventArgs e)
        {
            labelDoor2.Controls.Remove(labelDoor1);
            labelDoor2.Dispose();
            labelKey2.Controls.Remove(labelKey1);
            labelKey2.Dispose();
        }

        private void labelKey3_MouseMove(object sender, MouseEventArgs e)
        {
            labelDoor3.Controls.Remove(labelDoor1);
            labelDoor3.Dispose();
            labelKey3.Controls.Remove(labelKey1);
            labelKey3.Dispose();
        }

        private void labelEnd_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Thanks for playing!");
            Cursor.Position = labelStart.PointToScreen(Point.Empty);

        }
    }
}
