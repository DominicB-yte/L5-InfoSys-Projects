using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP05DialogLab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            DialogResult selected;
            ColorDialog myColourDialog;
            myColourDialog = new ColorDialog();
            selected = myColourDialog.ShowDialog();

            if (selected == DialogResult.OK)
            {
                txtColourConfirm.Text = "User clicked OK";
            }
            else
            {
                txtColourConfirm.Text = "User clicked Cancel";
            }

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult selected;
            FontDialog myFontDialog;
            myFontDialog = new FontDialog();
            selected = myFontDialog.ShowDialog();

            if (selected == DialogResult.OK)
            {
                txtFontConfirm.Text = "User clicked OK";
            }
            else
            {
                txtFontConfirm.Text = "User clicked Cancel";
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            DialogResult selected;
            FolderBrowserDialog myFolderDialog;
            myFolderDialog = new FolderBrowserDialog();
            selected = myFolderDialog.ShowDialog();

            if (selected == DialogResult.OK)
            {
                txtFolderConfirm.Text = "User clicked OK";
            }
            else
            {
                txtFolderConfirm.Text = "User clicked Cancel";
            }
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            DialogResult selected;
            OpenFileDialog myOpenFileDialog;
            myOpenFileDialog = new OpenFileDialog();
            selected = myOpenFileDialog.ShowDialog();

            if (selected == DialogResult.OK)
            {
                txtFileOpenConfirm.Text = "User clicked OK";
            }
            else
            {
                txtFileOpenConfirm.Text = "User clicked Cancel";
            }
        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {
            DialogResult selected;
            SaveFileDialog mySaveFileDialog;
            mySaveFileDialog = new SaveFileDialog();
            selected = mySaveFileDialog.ShowDialog();

            if (selected == DialogResult.OK)
            {
                txtFileSaveConfirm.Text = "User clicked OK";
            }
            else
            {
                txtFileSaveConfirm.Text = "User clicked Cancel";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult selected;
            PrintDialog myPrintDialog;
            myPrintDialog = new PrintDialog();
            selected = myPrintDialog.ShowDialog();

            if (selected == DialogResult.OK)
            {
                txtPrintConfirm.Text = "User clicked OK";
            }
            else
            {
                txtPrintConfirm.Text = "User clicked Cancel";
            }
        }

        private void btnCustom1_Click(object sender, EventArgs e)
        {
            Custom1 LoginPage;
            LoginPage = new Custom1();
            LoginPage.ShowDialog();

            if (LoginPage.IsLocked == false)
            {
                txtCustom1.Text = "User gave Input";
            }
        }

        private void btnCustom2_Click(object sender, EventArgs e)
        {
            Custom2 LoginPage;
            LoginPage = new Custom2();
            LoginPage.ShowDialog();

            if (LoginPage.IsLocked == false)
            {
                txtCustom2.Text = "User gave Input";
            }
        }
    }
}
