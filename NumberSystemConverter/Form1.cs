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
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {

            int decInput = 0;
            int decOutput = 0;
            int binaryOutput = 0;

            string input_decNumber;
            string input_binaryNumber;
            string input_hexNumber;

            string output_dec;
            string output_binary;
            string output_hex;

            // convert Decimal to Binary
            if (comboBox_input.SelectedIndex == 0 && comboBox_output.SelectedIndex == 1)
            {

                input_decNumber = txt_input.Text;
                decInput = Int32.Parse(input_decNumber);

                output_binary = Convert.ToString(decInput, 2);

                txt_output.Text = output_binary;

            }
            // Convert Decimal to Hex
            else if (comboBox_input.SelectedIndex == 0 && comboBox_output.SelectedIndex == 2)
            {

                input_decNumber = txt_input.Text;
                decInput = Int32.Parse(input_decNumber);

                output_hex = decInput.ToString("X");

                txt_output.Text = output_hex;

            }
            // Convert Binary to Decimal
            else if (comboBox_input.SelectedIndex == 1 && comboBox_output.SelectedIndex == 0)
            {

                input_binaryNumber = txt_input.Text;

                output_dec = Convert.ToInt32(input_binaryNumber, 2).ToString();

                txt_output.Text = output_dec;

            }
            // Convert Binary to Hex
            else if (comboBox_input.SelectedIndex == 1 && comboBox_output.SelectedIndex == 2)
            {

                input_binaryNumber = txt_input.Text;

                output_hex = Convert.ToInt32(input_binaryNumber, 2).ToString("X");

                txt_output.Text = output_hex;

            }
            // Convert Hex to Decimal
            else if (comboBox_input.SelectedIndex == 2 && comboBox_output.SelectedIndex == 0)
            {

                input_hexNumber = txt_input.Text;

                decOutput = Convert.ToInt32(input_hexNumber, 16);

                txt_output.Text = decOutput.ToString();

            }
            // Convert Hex to Binary
            else if (comboBox_input.SelectedIndex == 2 && comboBox_output.SelectedIndex == 1)
            {

                input_hexNumber = txt_input.Text;

                output_binary = Convert.ToString(Convert.ToInt64(input_hexNumber, 16), 2);

                txt_output.Text = output_binary;

            }

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

            if (comboBox_input.SelectedIndex == 0)
                label_input.Text = "Decimal";
            else if (comboBox_input.SelectedIndex == 1)
                label_input.Text = "Binary";
            else if (comboBox_input.SelectedIndex == 2)
                label_input.Text = "Hex";

        }

        // Selcet number_system you want to convert to
        private void ComboBox_output_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_output.SelectedIndex == 0)
                label_output.Text = "Decimal";
            else if (comboBox_output.SelectedIndex == 1)
                label_output.Text = "Binary";
            else if (comboBox_output.SelectedIndex == 2)
                label_output.Text = "Hex";

        }
    }
}
