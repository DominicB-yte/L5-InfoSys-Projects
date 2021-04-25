using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesCoursework
{
    public partial class Form2 : Form
    {
        private Person Dan;
        private Employee Alice, Bob;
        private Manager Cindy;
        public Form2()
        {
            InitializeComponent();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Make an employee named Alice
            Alice = new Employee();
            Alice.firstName = "Alice ";
            Alice.lastName = "Archer ";
            Alice.street = "100 Ash Ave ";
            Alice.city = "Bugsville ";
            Alice.state = "CO ";
            Alice.zip = "82010 ";
            Alice.employeeId = 1001;
            Alice.mailStop = "A-1 ";


            //Make an employee named Bob
            Bob = new Employee();
            Bob.firstName = "Bob ";
            Bob.lastName = "Benson ";
            Bob.street = "150 Malt Rd ";
            Bob.city = "Arlington ";
            Bob.state = "WA ";
            Bob.zip = "20218 ";
            Bob.employeeId = 1002;
            Bob.mailStop = "B-2 ";

            //Make a person named Dan
            Dan = new Person();
            Dan.firstName = "Dan ";
            Dan.lastName = "Drahmin ";
            Dan.street = "200 Bark St ";
            Dan.city = "Rey de Selva ";
            Dan.state = "CA ";
            Dan.zip = "45829 ";

            //Make an manager named Cindy
            Cindy = new Manager();
            Cindy.firstName = "Cindy ";
            Cindy.lastName = "Carrion ";
            Cindy.street = "250 Mire Ln ";
            Cindy.city = "Bannenburg ";
            Cindy.state = "VT ";
            Cindy.zip = "721528 ";
            Cindy.employeeId = 1003;
            Cindy.mailStop = "C-3 ";
            Cindy.directReports.Add(Alice);
            Cindy.directReports.Add(Bob);
        }

        private void btnAlice_Click(object sender, EventArgs e)
        {
            showAddress(Alice);
        }

        private void btnBob_Click(object sender, EventArgs e)
        {
            showAddress(Bob);
        }

        private void btnDan_Click(object sender, EventArgs e)
        {
            showAddress(Dan);
        }

        private void btnCindy_Click(object sender, EventArgs e)
        {
            showAddress(Cindy);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cindy.getDirectReportsList());
        }

        //Display this person's address
        private void showAddress(Person person)
        {
            MessageBox.Show(person.getAddress());
        }

    }
}
