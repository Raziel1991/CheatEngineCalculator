using System;
using System.Windows.Forms;

namespace HexSubtractionApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtHex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the hexadecimal numbers from the text boxes
                string hexNumber1 = txtHex1.Text;
                string hexNumber2 = txtHex2.Text;

                // Convert the hexadecimal strings to long integers
                long num1 = Convert.ToInt64(hexNumber1, 16);
                long num2 = Convert.ToInt64(hexNumber2, 16);

                // Perform the subtraction
                long result = num1 - num2;

                // Convert the result back to a hexadecimal string
                string hexResult = result.ToString("X");

                // Display the result in the label
                textResult1.Text = hexResult;
            }
            catch
            {
                // If there's an error in conversion, clear the result label
                textResult1.Text = "Result: Invalid input";
            }
        }

        private void buttonCopy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textResult1.Text);
        }
    }
}
