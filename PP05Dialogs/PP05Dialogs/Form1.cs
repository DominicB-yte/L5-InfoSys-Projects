using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP05Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColourDialog_Click(object sender, EventArgs e)
        {
            DialogResult cOutcome;
            //1st Step
            ColorDialog cDialog;
            cDialog = new ColorDialog();

            //2nd Step
            cOutcome = cDialog.ShowDialog();

            if (cOutcome == DialogResult.OK)
            {
                btnShowDialog.BackColor = cDialog.Color;
            }
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            DialogResult fntOutcome;
            //1st Step
            FontDialog fntDialog;
            fntDialog = new FontDialog();

            //2nd Step
            fntOutcome = fntDialog.ShowDialog();

            if (fntOutcome == DialogResult.OK)
            {
                btnFontDialog.Font = fntDialog.Font;
            }
        }

        private void btnVariable_Click(object sender, EventArgs e)
        {
            //Declare the VAriable
            Button varButton;
            //Initialise it
            varButton = new Button();
            varButton.Text = "Hola";
            varButton.Parent = this;
            varButton.Location = new Point(btnVariable.Left, btnVariable.Top + btnVariable.Height);
            varButton.Height = 38;
        }

        private void btnFolderDialog_Click(object sender, EventArgs e)
        {
            DialogResult fldrOutcome;
            //1st Step
            FolderBrowserDialog fldrDialog;
            fldrDialog = new FolderBrowserDialog();

            //2nd Step
            fldrOutcome = fldrDialog.ShowDialog();

            if (fldrOutcome == DialogResult.OK)
            {
                textBox1.Text = fldrDialog.SelectedPath;
            }
        }


        private void btnFileopenDialog_Click(object sender, EventArgs e)
        {
            {
                DialogResult flopOutcome;
                //1st Step
                OpenFileDialog flopDialog;
                flopDialog = new OpenFileDialog();

                //2nd Step
                flopOutcome = flopDialog.ShowDialog();

                if (flopOutcome == DialogResult.OK)
                {
                    textBox1.Text = flopDialog.FileName;
                }
            }

        }

        private void btnFilesaveDialog_Click(object sender, EventArgs e)
        {
            {
                DialogResult flsvOutcome;
                //1st Step
                SaveFileDialog flsvDialog;
                flsvDialog = new SaveFileDialog();

                //2nd Step
                flsvOutcome = flsvDialog.ShowDialog();

                if (flsvOutcome == DialogResult.OK)
                {
                    textBox1.Text = flsvDialog.FileName;
                }
            }
        }

        private void btnPrintDialog_Click(object sender, EventArgs e)
        {
            {
                DialogResult prntOutcome;
                //1st Step
                PrintDialog prntDialog;
                prntDialog = new PrintDialog();

                //2nd Step
                prntOutcome = prntDialog.ShowDialog();

                //if (prntOutcome == DialogResult.OK)
                {
                    //textBox1.Text = prntDialog.;
                }
            }
        }

        private void btnCustomDialog_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DiaLockd LoginPage;
            LoginPage = new DiaLockd();
            LoginPage.ShowDialog();
            
            if (LoginPage.IsLocked == false)
            {
                lbLockd.Text = "[OPN]";
            }
        }
    }
}
