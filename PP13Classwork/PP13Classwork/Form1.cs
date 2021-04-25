using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP13Classwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum contactMethods
        {
            None,
            Email,
            Phone,
            PublicMail,
        }
        struct personDetails
        {
            public string name;
            public string street;
            public string city;
            public string state;
            public string zip;
            public string email;
            public string phone;
            public contactMethods preffered;
        }
        personDetails thePerson;
        Dictionary<string, personDetails> Filecabinet = new Dictionary<string, personDetails>();


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbContact.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            thePerson.name = txtName.Text;
            thePerson.street = txtStreet.Text;
            thePerson.city = txtCity.Text;
            thePerson.state = txtState.Text;
            thePerson.zip = txtZIP.Text;
            thePerson.email = txtEmail.Text;
            thePerson.phone = txtPhone.Text;
            thePerson.preffered = (contactMethods)cmbContact.SelectedIndex;

            Filecabinet.Add(txtName.Text, thePerson);

            txtName.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZIP.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cmbContact.SelectedIndex = 0;
            txtName.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            personDetails the2Person = Filecabinet[txtName.Text];

            txtName.Text = the2Person.name;
            txtStreet.Text = the2Person.street;
            txtCity.Text = the2Person.city;
            txtState.Text = the2Person.state;
            txtZIP.Text = the2Person.zip;
            txtEmail.Text = the2Person.email;
            txtPhone.Text = the2Person.phone;
            cmbContact.SelectedIndex = (int)the2Person.preffered;

        }
    }
}
