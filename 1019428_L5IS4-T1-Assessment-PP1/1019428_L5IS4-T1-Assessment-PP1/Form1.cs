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
    public partial class Form1 : Form
    {
        DateTime date;
        DateTime hours;
        DateTime minutes;
        public Form1()
        {
            InitializeComponent();
        }





        private void btnAim_Click(object sender, EventArgs e)
        {
            Meeting_Aim MeetingPage;
            MeetingPage = new Meeting_Aim();
            MeetingPage.ShowDialog();

            if (MeetingPage.meeting == 1)
            {
                btnAim.Text = "Meeting";
            }

                if (MeetingPage.sales == 1)
                {
                    btnAim.Text = "Sales Appointment";
                }

                if (MeetingPage.visit == 1)
                {
                    btnAim.Text = "Site Visit";
                }

            if (MeetingPage.interview == 1)
            {
                btnAim.Text = "Student Interview";
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.BackColor = Color.Salmon;              
            }
            if (txtSurname.Text == "")
            {
                txtSurname.BackColor = Color.Salmon;
            }
            if (txtMobile.Text == "")
            {
                txtMobile.BackColor = Color.Salmon;
            }
            if (txtEmail.Text == "")
            {
                txtEmail.BackColor = Color.Salmon;
            }

            //if //(datetimeMeeting <= DateTime.Now)
            {
                //txtName.BackColor = Color.Salmon;
            }

            int mins;
            int hrs;

            string name = txtName.Text;
            string surname = txtSurname.Text;
            string meetname = cmbWith.Text;
            string minutes = numUpDown_Minute.Text;
            string hours = numUpDown_Hour.Text;
            string meetType = btnAim.Text;

            mins = int.Parse(minutes);
            hrs = int.Parse(hours);

            lboxMeetings.Items.Add(
                "[" + meetType +  "]" + "\t" + name.Substring(0, 1) + "." + 
                    surname + " " + "-" + " " + meetname + " " + "at" + " " + hours + ":" + minutes
                );
        }


        private void lboxMeetings_KeyDown(object sender, KeyEventArgs e)
        {
            //Input is when the delete key is pressed, and Output is the selected item being
            //deleted from the listbox.
            
            //the code first check if the delete key has been presssed when a key is held down,
            //then the line "Delete key pressed" will be written into the output window,
            //then the code checks if the selected items in the listbox is less than or
            //equal to 0, then whatever item is selected will be removed from the listbox
            if (e.KeyCode == Keys.Delete)
            {
                Console.WriteLine("Delete key pressed");
                if (this.lboxMeetings.SelectedIndex >= 0)
                    this.lboxMeetings.Items.RemoveAt(this.lboxMeetings.SelectedIndex);
            }
        }
    }
}
