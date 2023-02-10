using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Calc.Group1AndMandeville
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var val = nudNum1.Value;

                decimal num1 = Convert.ToDecimal(tbNum1.Text);
                var num2 = Convert.ToDecimal(tbNum2.Text);

                var sum = num1 + num2;

                lblResult.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("please enter valid numerals!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNum1.Text = string.Empty;
                tbNum2.Text = string.Empty;
                //throw;
            }
        }

        private void tbNum1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
