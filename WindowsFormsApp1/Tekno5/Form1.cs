using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekno5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Check if input is a positive integer
            if (!int.TryParse(txtRank.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Please enter a positive integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int fib = 0;

            if (n == 1)
            {
                fib = 0;
            }
            else if (n == 2)
            {
                fib = 1;
            }
            else
            {
                int prev1 = 0;
                int prev2 = 1;

                for (int i = 3; i <= n; i++)
                {
                    fib = prev1 + prev2;
                    prev1 = prev2;
                    prev2 = fib;
                }
            }

            txtNumber.Text = fib.ToString();
        }
    }
}
