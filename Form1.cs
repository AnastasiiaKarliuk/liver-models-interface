using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            instructions.Visible = true;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            grade1.Visible = true;
            grade2.Visible = true;
            grade3.Visible = true;
            hide.Enabled = true;
            details.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Double x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x;
            Double m1, m2, m3;

            var numbers = new List<double>();
            var vars = new List<TextBox>() { X1, X2, X3, X4, X5, X6, X7, X8, X9, X10, X11, X12, X13, X14, X15, X16, X17, X18, X19 };

            grade1.Visible = false;
            grade2.Visible = false;
            grade3.Visible = false;
            hide.Enabled = false;
            details.Enabled = true;

            foreach (TextBox i in vars)
            {
                if (!string.IsNullOrEmpty(i.Text))
                {                 
                    x = Convert.ToDouble(i.Text); ;
                    numbers.Add(x);
                    Console.WriteLine(x);
                    if (i == X19)
                    {
                        x1 = numbers[0];
                        x2 = numbers[1];
                        x3 = numbers[2];
                        x4 = numbers[3];
                        x5 = numbers[4];
                        x6 = numbers[5];
                        x7 = numbers[6];
                        x8 = numbers[7];
                        x9 = numbers[8];
                        x10 = numbers[9];
                        x11 = numbers[10];
                        x12 = numbers[11];
                        x13 = numbers[12];
                        x14 = numbers[13];
                        x15 = numbers[14];
                        x16 = numbers[15];
                        x17 = numbers[16];
                        x18 = numbers[17];
                        x19 = numbers[18];

                        if (string.IsNullOrEmpty(meth.Text))
                        {
                           
                            MessageBox.Show(" No one method is choosen.\n Please, choose method of segmentation", "Value ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {

                            if (meth.Text == "2.1")
                            {
                                m1 = -0.453 + 0.58 * x2 * x10 + 0.358 * Math.Pow(x18, 2) + 0.0003 * x3 * x6 - 0.134 * x4 * x11 +
                                    0.06 * x1 * x19 + 0.089 * Math.Pow(x10, 2) + 14.458 * x3 * x11 - 0.906 * x3 * x7 - 0.053 * x1 * x14;

                                m2 = -0.076 + 22.263 * x8 * x11 - 49.747 * x2 * x11 + 1.955 * x2 * x17 - 0.453 * x10 * x18 +
                                    0.0005 * x3 * x6 + 0.224 * x7 * x14 - 0.401 * x10 * x17 - (1.92e-07) * x6 * x12 -
                                    0.002 * x3 * x5 + 48.273 * x11 * x15;

                                m3 = 0.246 - 37.666 * x8 * x11 - 1.381 * x2 * x17 + 0.434 * x10 * x17 + (2.61e-06) * Math.Pow(x5, 2) +
                                    0.473 * x8 * x10 - 0.0007 * x3 * x6 - 0.256 * x1 * x19 + 0.0007 * x1 * x12 - (1.53e-05) * x5 * x14;

                                result.Text = check_models(m1, m2, m3);
                            }

                            if (meth.Text == "LIVER")
                            {
                                m1 = 0.133 + 27.788 * Math.Pow(x2, 2) - 0.17 * x4 * x7 + 1.209 * x2 * x14 - 0.0003 * x12 * x17 -
                                   4.207 * x2 * x19 - 11.983 * x2 * x7 - 159.092 * x2 * x15 + 15.698 * x2 * x8 -
                                   0.409 * x2 * x4 + 0.005 * x2 * x12 + 0.006 * x2 * x5 + 4.569 * x2 * x18 - 3.557 * x2 * x13 -
                                   155.426 * x2 + 123.007 * x2 * x9 + 33.941 * x2 * x11 + 13.21 * x2 * x17 + 0.002 * x2 * x6 +
                                   41.514 * x2 * x16 + 0.029 * x4 * x10;

                                m2 = 4.714 - 0.116 * x9 * x12 - 0.602 * x2 * x19 + 106.325 * Math.Pow(x11, 2) + 25.829 * x4 * x11 +
                                    1.347 * x2 * x13 + 0.008 * x2 * x6 - 0.028 * x2 * x5 + 2.762 * x4 * x18 - 21.009 * x13 * x19 +
                                    0.212 * x12 * x18 + 19.927 * x13 - 1.819 * x7 * x16 + 0.254 * x14 * x19 - 33.182 * x11 * x19 -
                                    2.779 * x4 * x9 + 0.0005 * x1 * x12 + 0.0006 * x3 * x6 - 2.316 * x4 * x7 + 0.914 * x3 * x13 +
                                    0.171 * x1 * x4 + 0.089 * x12 - 0.369 * x11 * x12;

                                m3 = -0.757 - 0.004 * x12 * x18 + 2215.54 * Math.Pow(x11, 2) - 1920.21 * x11 * x17 - 3.648 * x7 * x13 -
                                    0.188 * x12 * x17 + 74.921 * x7 * x17 - 14.526 * x16 * x17 + 0.865 * x10 * x14 + 3.029 * Math.Pow(x13, 2) -
                                    32.018 * x13 * x17 + 0.006 * x12 * x15 + 110.99 * x11 * x13 - 98.077 * x11 + 12.683 * x4 * x17 -
                                    1.146 * x4 * x13 + 10.351 * x7 + 0.013 * x3 * x12 - 7.531 * x3 * x15 + 130.383 * x3 * x11 +
                                    2.137 * x16 * x16 - 1.193 * x8 * x14 - 6.009 * x10 * x15 + 0.752 * x3 * x4 + 8.546 * x15 +
                                    6.343 * x17 * x19;

                                result.Text = check_models(m1, m2, m3);
                            }

                            if (meth.Text == "41")
                            {
                                m1 = -4.854 + 3.216 * x2 * x10 + 1.186 * x11 * x12 - 1.877 * x4 * x7 + 0.94 * x8 * x10 +
                                    51.536 * x10 * x15 + 1.755 * Math.Pow(x19, 2) - 0.004 * x12 * x13 + 0.45 * x3 * x4 - 16.092 * x10 * x16 -
                                    0.007 * x3 * x12 - 2.275 * x3 * x18 + 5.389 * x3 * x9 - 41.588 * x2 * x11 + 0.65 * x13 -
                                    217.536 * x3 * x15 + 0.0006 * x6 * x13 + 2.727 * x1 * x9 + 0.398 * x4 * x10 +
                                    0.0009 * x1 * x1 * x6 + 0.648 * x3 * x13 + 65.068 * x3 * x16 - 0.0002 * x2 * x12 +
                                    0.002 * x12 * x14 - 0.003 * x12 * x18;

                                m2 = -34.045 - (2.62e-06) * Math.Pow(x12, 2) - 0.852 * x2 * x19 - 1.174 * x11 * x12 - 42.955 * Math.Pow(x18, 2) -
                                    5.96 * x7 * x18 + 0.003 * x2 * x6 + 0.144 * x2 * x14 - 0.024 * x9 * x12 - 0.364 * x4 * x15 -
                                    143.057 * Math.Pow(x17, 2) - 142.231 * x11 * x13 + 0.27 * x10 * x14 + 0.017 * x12 * x15 + 83.704 * x18 +
                                    0.047 * x4 * x19 - 6476.3 * Math.Pow(x11, 2) + 2268.92 * x11 * x17 + 3.214 * x7 * x13 + 0.417 * x4 * x18 -
                                    2.807 * x17 * x19;

                                m3 = -16.347 + 3635.89 * Math.Pow(x11, 2) + 17.266 * x7 * x18 - 0.406 * Math.Pow(x4, 2) + 25.478 * x8 * x17 +
                                    160.829 * x11 * x16 + 0.024 * x12 * x17 - 540.603 * x11 * x18 + 1.857 * x4 * x9 -
                                    9.666 * x9 * x16 + 0.149 * Math.Pow(x14, 2) + 0.009 * x3 * x12 - 0.37 * x3 * x4 + 0.028 * x7 * x12 -
                                    1.046 * x4 * x18 - 32.557 * x15 + 0.655 * x3 * x19 + 1.149 * x1 * x13 - 0.311 * x1 * x19 +
                                    2.108 * x17 * x19 - 0.001 * x8 * x12;

                                result.Text = check_models(m1, m2, m3);
                            }

                            if (meth.Text == "SNAP")
                            {
                                m1 = -2.084 + 16.775 * x2 * x10 - 1.434 * x2 * x14 + (6.04e-05) * x4 * x6 - 33.07 * x2 * x7 + 30.615 * x2 * x16 -
                                    8.25 * x2 - 0.002 * x2 * x12 + 0.159 * x12 * x16 - 1.906 * x4 * x7 + 0.275 * x3 * x4 - 0.008 * x12 * x17 +
                                    0.128 * x4 * x15 - 0.566 * x1 * x14 - 0.007 * x3 * x12 - 0.861 * x3 * x3 - 0.167 * x8 * x18 - 20.913 * x16 +
                                    17.008 * x7 * x9 - 0.801 * x2 * x18 + 0.399 * x13 * x17;

                                m2 = 5.247 - 5.105 * x2 / x14 - 277.973 * x11 / x4 - 46.514 * x11 / x7 - 0.601 * x3 / x13 - 122.474 * x1 / x6 -
                                    0.009 * x1 * x6 + 33.33 * x3 / x11 - 0.004 * x12 / x18 - 0.326 * x3 / x13 + 0.005 * x6 / x7 - 2.246 * x8 * x18 +
                                    60.507 * x11 * x15 - 221.631 * x13 / x12 + 27.801 * x14 / x12 + 0.059 * x1 * x5 - 0.005 * x12 / x17 -
                                    3.402 * x9 / x14 - 0.007 * x12 / x18 - 1.334 * x3 / x18 + 8.701 * x3 / x4 + 1548.92 * x11 / x12 +
                                    2.472 * x2 / x10 + 0.229 * x1 / x14 + 0.558 / (x13 * x15) + 0.001 * x4 * x12;

                                m3 = 0.381 - 392.088 * x14 * x17 - 2.263 * x14 * x17 + 0.004 * x12 * x14 + 335.092 * x7 * x11 + 6.241 * Math.Pow(x17, 2) +
                                    89.764 * x11 * x14 + 4.271 * x7 * x13 + 0.363 * x13 * x14 + 0.115 * x2 * x4 + 0.037 * x2 * x5 - 0.004 * x2 * x6 -
                                    3.253 * x2 * x9 - 0.002 * x6 * x13 - 0.009 * x12 * x17 + 0.249 * x3 * x18 - 1.968 * x3 * x10 + 0.003 * x1 * x6 -
                                    0.183 * x4 * x18 + 0.254 * x4 - 9.214 * x4 * x11 + 1.737 * x2 * x18 + 0.001 * x1 * x12 - 0.553 * x10 * x14 +
                                    0.002 * x3 * x5;

                                result.Text = check_models(m1, m2, m3);

                            }

                            String check_models(Double m_1, Double m_2, Double m_3)
                            {
                                String result_;

                                grade1.Text = "Some text  "+m_1.ToString();
                                grade2.Text = "Some text  "+m_2.ToString();
                                grade3.Text = m_3.ToString();

                                if (m_1 > 0)
                                {
                                    result_ = "It is the first grade";
                                }
                                else
                                {
                                    if (m_2 > 0)
                                    {
                                        result_ = "It is the second grade";
                                    }
                                    else
                                    {
                                        if (m_3 > 0)
                                        {
                                            result_ = "It is the third grade";
                                        }
                                        else
                                        {
                                            result_ = "You have nothing";
                                        }
                                    }
                                }
                                return result_;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No one value\nPlease, enter all values", "Value ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break; 
                }
            }            
        }

        private void meth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void X15_TextChanged(object sender, EventArgs e)
        {

        }

        private void details_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            grade1.Visible = false;
            grade2.Visible = false;
            grade3.Visible = false;
            hide.Enabled = false;
            details.Enabled = true;
        }

        private void grade2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void X1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X1.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X2.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X3.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X4.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X5.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X6.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X7.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X8.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X9_TextChanged(object sender, EventArgs e)
        {

        }

        private void X9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X9.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X10.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X11.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X12.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X13.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X14_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X14.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X15.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X16_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X16.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X17_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X17.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X18_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X18.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void X19_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || X19.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void X10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void X13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void X18_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
