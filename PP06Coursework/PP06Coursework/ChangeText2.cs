using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP06Coursework
{
    public partial class ChangeText2 : Form
    {
        public ChangeText2()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string replaceTo = txtReplaceTo.Text;
            string replaceWith = txtReplaceWith.Text;
            string replaced = input.Replace(replaceTo, replaceWith);
            txtInput.Text = replaced;
            txtReplaceTo.Clear();
            txtReplaceWith.Clear();
            txtInput.Focus();
        }
    }
}
