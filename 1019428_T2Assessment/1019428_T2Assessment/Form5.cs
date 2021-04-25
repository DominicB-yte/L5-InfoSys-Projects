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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        SqlConnection connection = null;
        SqlCommand command = null;
        string ConnectionString = @"Data Source=DOMINICBURNETT-;Initial Catalog=1019428_T2Assessment;Integrated Security=True";

        private void Sales_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = "select ProdName, ProdQuantity, floor(ProdQuantity * 0.20) as ProdSales, ProdPrice from [TechProducts]";
            command = new SqlCommand(query);
            command.Connection = connection;

            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataViewSales.DataSource = dt;
            connection.Close();
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            AmountSold AmountSoldPage;
            AmountSoldPage = new AmountSold();
            AmountSoldPage.ShowDialog();
        }

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {
            Main MainPage;
            MainPage = new Main();
            MainPage.ShowDialog();
        }
    }
}
