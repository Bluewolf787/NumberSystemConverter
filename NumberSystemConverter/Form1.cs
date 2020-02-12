using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberSystemConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox_input.SelectedIndex = 0;
            comboBox_output.SelectedIndex = 2;

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {

            int decInput = 0;

            string inputDec;
            string inputAscii;
            string inputBin;
            string inputHex;

            string outputDec;
            string outputAscii;
            string outputBin;
            string outputHex;

            int inputSelection = comboBox_input.SelectedIndex;
            int outputSelection = comboBox_output.SelectedIndex;

            /* INPUT/OUTPUT    INDEX
             * Decimal         0
             * ASCII           1
             * Binary          2
             * Hexadecimal     3
             */
            
            // Convert Decimal to ASCII
            if (inputSelection == 0 && outputSelection == 1)
            {

                inputDec = txt_input.Text;
                String[] dec = new String[0];
                outputAscii = string.Empty;

                try
                {
                    // Store decimal numbers in array 'dec'
                    foreach (var t in inputDec)
                    {
                        dec = inputDec.Split(' ');
                    }

                    // Convert every element (decimal number) stored in 'dec' to an ASCII char
                    foreach (var element in dec)
                    {
                        outputAscii += Convert.ToChar(Convert.ToByte(element)).ToString();
                    }

                }
                catch (Exception ex)
                {
                    if (ex is ArgumentOutOfRangeException)
                    {
                        MessageBox.Show(
                            "Invailed input! Try to use a '0' in front of the number when you want to convert a single number, which is less than 100.",
                            "Argument Out Of RangeException",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex is FormatException)
                    {
                        MessageBox.Show("Invailed input! There is no actual decimal number", "Format Exeption",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);   
                    }
                    
                }

                txt_output.Text = outputAscii;

            }
            // Convert Decimal to Binary
            else if (inputSelection == 0 && outputSelection == 2)
            {

                inputDec = txt_input.Text;

                String[] dec = new String[0];
                outputBin = string.Empty;

                // Store decimal numbers in array 'dec'
                foreach (var t in inputDec)
                {
                    dec = inputDec.Split(' ');
                }

                try
                {
                    // Convert every element (decimal number) stored in 'dec' to an binary number
                    foreach (var element in dec)
                    {
                        decInput = Int32.Parse(element);
                        outputBin += Convert.ToString(decInput, 2) + " ";
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invailed input! There is no actual decimal number", "Format Exeption",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_output.Text = outputBin;

            }
            // Convert Decimal to Hex
            else if (inputSelection == 0 && outputSelection == 3)
            {

                inputDec = txt_input.Text;

                String[] dec = new String[0];
                outputHex = string.Empty;

                // Store decimal numbers in array 'dec'
                for (var i = 0; i < inputDec.Length; i++)
                {
                    dec = inputDec.Split(' ');
                }

                try
                {
                    // Convert every element (decimal number) stored in 'dec' to an hexadecimal number
                    foreach (var element in dec)
                    {
                        decInput = Int32.Parse(element);
                        outputHex += decInput.ToString("X") + " ";
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invailed input! There is no actual decimal number", "Format Exeption",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_output.Text = outputHex;

            }
            // Convert ASCII to Decimal
            else if (inputSelection == 1 && outputSelection == 0)
            {

                inputAscii = txt_input.Text;
                outputDec = string.Empty;

                for (var i = 0; i < inputAscii.Length; ++i)
                {
                    string cDec = ((byte)inputAscii[i]).ToString();

                    if (cDec.Length < 3)
                        cDec = cDec.PadLeft(3, '0');

                    outputDec += cDec + " ";
                }

                txt_output.Text = outputDec;

            }
            // Convert ASCII to Binary
            else if (inputSelection == 1 && outputSelection == 2)
            {

                inputAscii = txt_input.Text;
                outputBin = string.Empty;

                byte[] bytes = Encoding.ASCII.GetBytes(inputAscii);
    
                for (var i = 0; i < bytes.Length; i++)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        outputBin += (bytes[i] & 0x80) > 0 ? "1" : "0";
                        bytes[i] <<= 1;
                    }
                    outputBin += " ";
                }
                
                // txt_output.Text = "Hello Wolrd!";
                txt_output.Text = outputBin;

            }
            // Convert ASCII to Hex
            else if (inputSelection == 1 && outputSelection == 3)
            {

                inputAscii = txt_input.Text;
                outputHex = String.Empty;

                char[] ascii = inputAscii.ToCharArray();

                foreach (var element in ascii)
                {
                    int value = Convert.ToInt32(element);
                    outputHex += String.Format("{0:X}", value) + " ";
                }

                txt_output.Text = outputHex.ToString().ToUpper();

            }
            // Convert Binary to Decimal
            else if (inputSelection == 2 && outputSelection == 0)
            {

                inputBin = txt_input.Text;

                String[] bin = new String[0];
                outputDec = string.Empty;

                // Store binary numbers in array 'bin'
                foreach (var t in inputBin)
                {
                    bin = inputBin.Split(' ');
                }

                try
                {
                    // Convert every element (binary number) stored in 'bin' to an decimal number
                    foreach (var element in bin)
                    {
                        outputDec += Convert.ToInt32(element, 2).ToString() + " ";
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invailed input! There is no actual decimal number", "Format Exeption",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_output.Text = outputDec;

            }
            // Convert Binary to ASCII
            else if (inputSelection == 2 && outputSelection == 1)
            {
                
                inputBin = txt_input.Text;
                String[] bin = new String[0];
                outputAscii = String.Empty;
                
                // Store binary numbers in array 'bin'
                foreach (var t in inputBin)
                {
                    bin = inputBin.Split(' ');
                }

                try
                {
                    // Convert every element (binary number) stored in 'bin' to an ASCII char
                    foreach (var element in bin)
                    {
                        outputAscii += Convert.ToChar(Convert.ToByte(element, 2)).ToString();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invailed input! There is no actual decimal number", "Format Exeption",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_output.Text = outputAscii;

            }
            // Convert Binary to Hex
            else if (inputSelection == 2 && outputSelection == 3)
            {

                inputBin = txt_input.Text;

                String[] bin = new String[0];
                outputHex = string.Empty;

                // Store binary numbers in array 'bin'
                foreach (var t in inputBin)
                {
                    bin = inputBin.Split(' ');
                }

                try
                {
                    // Convert every element (binary number) stored in 'bin' to an hexadecimal number
                    foreach (var element in bin)
                    {
                        outputHex += Convert.ToInt32(element, 2).ToString("X") + " ";
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invailed input! There is no actual decimal number", "Format Exeption",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_output.Text = outputHex;

            }
            // Convert Hex to Decimal
            else if (inputSelection == 3 && outputSelection == 0)
            {

                inputHex = txt_input.Text;

                String[] hex = new String[0];
                outputDec = String.Empty;

                // Store hexadecimal numbers in array 'hex'
                foreach (var t in inputHex)
                {
                    hex = inputHex.Split(' ');
                }

                try
                {
                    // Convert every element (hexadecimal number) stored in 'hex' to an decimal number
                    foreach (var element in hex)
                    {
                        outputDec += Convert.ToString(Convert.ToInt32(element, 16)) + " ";
                    }
                    txt_output.Text = outputDec;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invailed input! There is no actual hexadecimal number", "Format Exeption",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            // Convert Hex to ASCII
            else if (inputSelection == 3 && outputSelection == 1)
            {

                inputHex = txt_input.Text;
                String[] hex = new String[0];
                outputAscii = String.Empty;
                
                // Store hexadecimal numbers in array 'hex'
                foreach (var t in inputHex)
                {
                    hex = inputHex.Split(' ');
                }

                try
                {
                    // Convert every element (hexadecimal number) stored in 'hex' to an ASCII char
                    foreach (var element in hex)
                    {
                        outputAscii += Convert.ToChar(Convert.ToByte(element, 16)).ToString();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invailed input! There is no actual decimal number", "Format Exeption",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_output.Text = outputAscii;

            }
            // Convert Hex to Binary
            else if (inputSelection == 3 && outputSelection == 2)
            {

                inputHex = txt_input.Text;

                String[] hex = new String[0];
                outputBin = String.Empty;

                // Store hexadecimal numbers in array 'hex'
                foreach (var t in inputHex)
                {
                    hex = inputHex.Split(' ');
                }

                try
                {
                    // Convert every element (hexadecimal number) stored in 'hex' to an binary number
                    foreach (var element in hex)
                    {
                        outputBin += Convert.ToString(Convert.ToInt64(element, 16), 2) + " ";
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invailed input! There is no actual hexadecimal number", "Format Exeption",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_output.Text = outputBin;

            }
            else if (inputSelection == outputSelection)
            {
                txt_output.Text = txt_input.Text;
            }

            // When copyed reset copy button
            if (btn_copy.Text == "COPYED")
                btn_copy.Text = "COPY";

        }

        // Clear all text boxes
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
            txt_output.Clear();
        }

        // Select number_system you want to convert from
        private void ComboBox_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_input.SelectedIndex)
            {
                case 0:
                    label_input.Text = "Decimal";
                    break;

                case 1:
                    label_input.Text = "ASCII";
                    break;

                case 2:
                    label_input.Text = "Binary";
                    break;

                case 3:
                    label_input.Text = "Hex";
                    break;
            }
        }

        // Selcet number_system you want to convert to
        private void ComboBox_output_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_output.SelectedIndex)
            {
                case 0:
                    label_output.Text = "Decimal";
                    break;

                case 1:
                    label_output.Text = "ASCII";
                    break;

                case 2:
                    label_output.Text = "Binary";
                    break;

                case 3:
                    label_output.Text = "Hex";
                    break;
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            // Copy output value
            Clipboard.SetText(txt_output.Text);
            btn_copy.Text = "COPYED";
        }
    }
}
