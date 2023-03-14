using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Tekno1 : Form
    {
        public Tekno1()
        {
            InitializeComponent();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(txtFirst.Text);
            int num2 = Int32.Parse(txtSecond.Text);
            int num3 = Int32.Parse(txtThird.Text);

            int result = (num1 + num2) * num3;

            txtResult.Text = result.ToString();
        }
    }
}
