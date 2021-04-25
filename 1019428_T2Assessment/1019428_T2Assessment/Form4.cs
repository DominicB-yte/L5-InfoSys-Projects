using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1019428_T2Assessment
{
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
        }

        public string setProdName;
        public string setQuantity;
        public bool setValues = false;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            setProdName = txtProduct.Text;
            setQuantity = txtQuantity.Text;
            setValues = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
