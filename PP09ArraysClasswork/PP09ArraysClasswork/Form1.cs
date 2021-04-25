using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP09ArraysClasswork
{
    public partial class Stopwatch : Form
    {
        DateTime timerStart;
        DateTime timerStop;
        public Stopwatch()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            timerStart = DateTime.Now;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerStop = DateTime.Now;
            timer1.Stop();
            //time betwen timerStart and timerStop is made a duration
            TimeSpan duration;
            duration = timerStop - timerStart;
            lblTimer.Text = duration.ToString(@"hh\:mm\:ss\.ff");

        }
        private void displayTime()
        {
            timerStop = DateTime.Now;
            //time betwen timerStart and timerStop is made a duration
            TimeSpan duration;
            duration = timerStop - timerStart;
            lblTimer.Text = duration.ToString(@"hh\:mm\:ss\.ff");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerStop = DateTime.Now;
            displayTime();
        }
    }
}
