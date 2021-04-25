using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1019428_T2Assessment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlConnection connection = new SqlConnection(@"Data Source = DOMINICBURNETT-; Initial Catalog = 1019428_T2Assessment;
                                                            Integrated Security = True");
            string firstName = username.Split(' ')[0];
            string lastInitial = username.Split(' ')[1];
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT EmpFirstName, SUBSTRING(EmpLastName, 1, 1), EmpPassword AS" +
                                                            " Initial FROM " + "TechEmployee" + " WHERE EmpFirstName = '" 
                                                            + firstName + "' AND EmpLastName LIKE '" + lastInitial + "%" +
                                                            "'" + " AND EmpPassword = '" + password + "'", connection);

            DataTable data = new DataTable();
            adapter.Fill(data);

            if (data.Rows.Count > 0)
            {
                Main MainPage;
                MainPage = new Main();
                MainPage.ShowDialog();
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect");
            }
        }
    }
}
