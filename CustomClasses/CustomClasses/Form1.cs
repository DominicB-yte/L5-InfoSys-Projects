using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentClass student = new StudentClass();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            student.FirstName = txtName.Text;
            student.StudentID = int.Parse(txtZIP.Text);
        }
    }
}
