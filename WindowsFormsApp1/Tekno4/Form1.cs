using MaxMind.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekno4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectedFile_Click(object sender, EventArgs e)

        {
            // Open a file dialog to select a text file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|(*.rtf)|*.rtf ";
            openFileDialog.Title = "Select a Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read the contents of the selected file
                    string fileContents = File.ReadAllText(openFileDialog.FileName);

                    // Split the file contents into individual numbers and add them to a list
                    List<double> numbers = new List<double>();
                    string[] numberStrings = fileContents.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string numberString in numberStrings)
                    {
                        double number;
                        if (double.TryParse(numberString.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out number))
                        {
                            numbers.Add(number);
                        }
                    }

                    // Sort the numbers in descending order
                    numbers.Sort();
                    numbers.Reverse();

                    // Display the sorted numbers in the output textbox
                    txtNumbers.Text = string.Join(Environment.NewLine, numbers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }
    }
}
