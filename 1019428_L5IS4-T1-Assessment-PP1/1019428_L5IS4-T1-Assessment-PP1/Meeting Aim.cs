using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1019428_L5IS4_T1_Assessment_PP1
{
    public partial class Meeting_Aim : Form
    {
        public int meeting = 0;
        public int sales = 0;
        public int visit = 0;
        public int interview = 0;
        public Meeting_Aim()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbtnMeeting.Checked == true)
                {
                    meeting = 1;
                    Close();
                }

           if (rbtnSales.Checked == true)
                {
                    sales = 1;
                    Close();
                }

           if (rbtnVisit.Checked == true)
                {
                    visit = 1;
                    Close();
                }

           if (rbtnInterview.Checked == true)
                {
                    interview = 1;
                    Close();
                }
                
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
