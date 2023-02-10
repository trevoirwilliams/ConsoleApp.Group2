using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Group2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstname.Text;
            var lastName = tbLastname.Text;

            // Submit to database, process, call an API to verify

            // Display a thank you message
            //MessageBox.Show("You are " + firstName + " " + lastName); // concatenation
            MessageBox.Show($"You are {firstName} {lastName}"); // interpolation
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            tbFirstname.Text = string.Empty;
            tbLastname.Text = string.Empty;
        }
    }
}
