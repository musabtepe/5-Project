using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekno2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            
            //Satır ve sütunu 15 ve 14 sayı üzerinden yazdırınca hem 3 hem de 5' in katları olan zigzag ve zagzig' ler çapraz olarak karşımıza çıkar. Tabi, yalnız 3 ve yalnız 5' in katları da aynı mantıkla, aynı düzende karşımıza çıkacaktır.

            for (int line = 1; line <= 15; line++) // Iterate over the 15 lines
            {
                for (int num = 1 + (line - 1) * 14; num <= line * 14; num++) // Iterate over the 14 numbers in each line
                {
                    if (num > 100 && (num % 3 == 0 && num % 5 == 0))
                    {
                        richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.AppendText("zagzig ");
                    }
                    else if (num % 3 == 0 && num % 5 == 0)
                    {
                        richTextBox1.SelectionColor = Color.Purple;
                        richTextBox1.AppendText("zigzag ");
                    }
                    else if (num % 3 == 0)
                    {
                        richTextBox1.SelectionColor = Color.Green;
                        richTextBox1.AppendText("zig ");
                    }
                    else if (num % 5 == 0)
                    {
                        richTextBox1.SelectionColor = Color.Blue;
                        richTextBox1.AppendText("zag ");
                    }
                    else
                    {
                        richTextBox1.SelectionColor = Color.Black;
                        richTextBox1.AppendText(num.ToString() + " ");
                    }

                   
                    richTextBox1.SelectionColor = Color.Black;
                }

                // Insert a newline character after each line
                richTextBox1.AppendText(Environment.NewLine);
            }
        }
    }
}