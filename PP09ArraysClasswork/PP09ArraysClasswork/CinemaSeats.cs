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
    public partial class CinemaSeats : Form
    {
        const int ROWS = 10;
        const int CLMN = 10;
        const int BUTTON_SIZE = 40;

        bool[,] bookedSeats = new bool[ROWS, CLMN];
        public CinemaSeats()
        {
            InitializeComponent();
        }
        private void CinemaSeats_Load(object sender, EventArgs e)
        {
            //Draw Rows
            for (int i = 0; i < ROWS; i++)
            {
                //Draw Columns
                for (int j = 0; j < CLMN; j++)
                {
                    GenerateButton(i, j);
                }
            }
        }
        private Button GenerateButton(int row, int clmn)
        {
            Button createdButton = new Button();
            createdButton.Parent = this;
            createdButton.Text = "";
            createdButton.BackColor = Color.IndianRed;
            createdButton.Name = row.ToString() + "|" + clmn.ToString();
            createdButton.Top = (row * BUTTON_SIZE);
            createdButton.Left = (clmn * BUTTON_SIZE);
            createdButton.Height = BUTTON_SIZE;
            createdButton.Width = BUTTON_SIZE;
            createdButton.Text = createdButton.Name;
            createdButton.Click += ButtonClick;


            return createdButton;
        }
        private void ButtonClick(object Sender, EventArgs e)
        {
            Button theClickedButon;

            theClickedButon = ((Button)Sender);

            string btnName = theClickedButon.Name;
            int clickedClmn;
            int clickedRow;

            clickedRow = Convert.ToInt32(theClickedButon.Name.Split('|')[0]);
            clickedClmn = Convert.ToInt32(theClickedButon.Name.Split('|')[0]);

            bookedSeats[clickedRow, clickedClmn] = 
                bookedSeats[clickedRow, clickedClmn];

            theClickedButon.BackColor = bookedSeats[clickedRow, clickedClmn]
                ? Color.IndianRed : Color.GreenYellow;

        }
    }
}
