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

namespace Tekno3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int n) && n >= 1 && n <= 15)
            {
                rtbTable.Clear();


                //Bu kod, o sütunda görüntülenecek maksimum değere (n * n) dayalı olarak her sütun için gereken maksimum genişliği hesaplar ve her sayıyı bu genişliğe kadar boşluklarla doldurur. Böylelikle, tüm sütunların aynı genişliğe sahip olmasını ve sayıların düzgün şekilde hizalanmasını sağlar.

                int maxWidth = (n * n).ToString().Length + 1;

                // Add 0 to top left corner -- Hizalamada sorun oluyor sürekli. Kurgudan çıkarıldı...

                // Add column headers
                rtbTable.AppendText("".PadRight(maxWidth));
                for (int i = 1; i <= n; i++)
                {
                    rtbTable.AppendText(i.ToString().PadRight(maxWidth));
                }
                rtbTable.AppendText(Environment.NewLine);

                // Add rows
                for (int i = 1; i <= n; i++)
                {
                    rtbTable.AppendText(i.ToString().PadRight(maxWidth));
                    for (int j = 1; j <= n; j++)
                    {
                        rtbTable.AppendText((i * j).ToString().PadRight(maxWidth));
                    }
                    rtbTable.AppendText(Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Please enter an integer between 1 and 15.");
            }
        }

    }
}
