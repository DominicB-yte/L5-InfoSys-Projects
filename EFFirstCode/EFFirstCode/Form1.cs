using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFFirstCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            using (var context = new PersonContext())
            {
                var NewPerson = new Person()
                {
                    Name = "Joe",
                    Surname = "Bloggs",
                    Age = 100
                };
                context.People.Add(NewPerson);
                context.SaveChanges();
            }
        }
    }
}
