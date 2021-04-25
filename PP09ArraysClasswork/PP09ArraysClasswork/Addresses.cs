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
    public partial class Addresses : Form
    {

        public Addresses()
        {
            InitializeComponent();
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
            public string preffered;
        }
        personDetails thePerson;
        Dictionary<string, personDetails> Filecabinet = new Dictionary<string, personDetails>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            thePerson.name = txtName.Text;
            thePerson.street = txtStreet.Text;
            thePerson.city = txtCity.Text;
            thePerson.state = txtState.Text;
            thePerson.zip = txtZIP.Text;
            thePerson.email = txtEmail.Text;
            thePerson.phone = txtPhone.Text;
            thePerson.preffered = cmbContact.Text;

            Filecabinet.Add(txtName.Text, thePerson);
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
            cmbContact.Text = the2Person.preffered;

        }
    }
}
