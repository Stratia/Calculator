using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String s;

        string number;
        string oper = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            //On-Ready
            Console.WriteLine("Program Initalized");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // On-Button Click
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            number += 1;
            s = number.ToString();
            richTextBox1.AppendText(s);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 6
            richTextBox1.Clear();
            number += 6;
            s = number.ToString();
            richTextBox1.AppendText(s);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1  
                Console.WriteLine("Program Initalized");
                richTextBox1.Clear();
                number += 1;
                s = number.ToString();
                richTextBox1.AppendText(s);
            
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Output
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Clear Button
            richTextBox1.Clear();
            richTextBox2.Clear();
            number = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 2
            richTextBox1.Clear();
            number += 2;
            s = number.ToString();
            richTextBox1.AppendText(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 3
            richTextBox1.Clear();
            number += 3;
            s = number.ToString();
            richTextBox1.AppendText(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 4
            richTextBox1.Clear();
            number += 4;
            s = number.ToString();
            richTextBox1.AppendText(s);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 5
            richTextBox1.Clear();
            number += 5;
            s = number.ToString();
            richTextBox1.AppendText(s);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 7
            richTextBox1.Clear();
            number += 7;
            s = number.ToString();
            richTextBox1.AppendText(s);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 8
            richTextBox1.Clear();
            number += 8;
            s = number.ToString();
            richTextBox1.AppendText(s);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // 9
            richTextBox1.Clear();
            number += 9;
            s = number.ToString();
            richTextBox1.AppendText(s);
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            //Equal
            richTextBox1.Clear();
            string parse = richTextBox2.Text;
            switch (oper)
            {
                case "÷":
                    {
                        string final4 = parse.Replace("÷", "");
                        var i4 = int.Parse(final4);
                        var n4 = int.Parse(number);
                        try
                        {
                            int calc_output4 = i4 / n4;
                            string knk4 = calc_output4.ToString();
                            richTextBox1.AppendText(knk4);
                            break;
                        }
                        catch
                        {
                            richTextBox1.AppendText("Error");
                            break;
                        }
                    }

                case "*":
                    {
                        //FormatException: 'Input string was not in a correct fo
                        string final3 = parse.Replace("*", "");
                        try
                        {
                            int calc_output3 = int.Parse(final3) * int.Parse(number);
                            string knk3 = calc_output3.ToString();
                            richTextBox1.AppendText(knk3);
                        }
                        catch
                        {
                            richTextBox1.AppendText("Error");
                        }
                        break;
                    }

                case "-":
                    {
                        try
                        {
                            string final2 = parse.Replace("-", "");
                            var i2 = int.Parse(final2);
                            var n2 = int.Parse(number);
                            int calc_output2 = i2 - n2;
                            string knk2 = calc_output2.ToString();
                            richTextBox1.AppendText(knk2);
                        }

                        catch
                        {
                            richTextBox1.AppendText("Error");
                        }
           
                        break;
                    }

                case "+":
                    string final = parse.Replace("+", "");
                    try
                    {
                        var i = int.Parse(final);
                        var n = int.Parse(number);
                        int calc_output = i + n;
                        string knk = calc_output.ToString();
                        richTextBox1.AppendText(knk);
                    }
                    catch
                    {
                        richTextBox1.AppendText("Error");
                    }
                    break;

            }
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Addition
            number = "";
            oper = "";
            oper = "+";
            Console.WriteLine(oper);
            try
            {
                // Using Try-Catch as fall back
                richTextBox1.Clear();
                richTextBox2.Clear();
                richTextBox2.AppendText("+");
                richTextBox2.AppendText(s);
            }
            catch
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Subtraction
            number = "";
            oper = "";
            oper = "-";
            try
            {
                richTextBox1.Clear();
                richTextBox2.Clear();
                richTextBox2.AppendText("-");
                richTextBox2.AppendText(s);
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Divison
            oper = "";
            oper = "÷";
            number = "";
            try
            {
                richTextBox1.Clear();
                richTextBox2.Clear();
                richTextBox2.AppendText("÷");
                richTextBox2.AppendText(s);
            }
            catch
            {

            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Multiply
            oper = "";
            oper = "*";
            number = "";
            try
            {
                richTextBox1.Clear();
                richTextBox2.Clear();
                richTextBox2.AppendText("*");
                richTextBox2.AppendText(s);
            }
            catch
            {

            }
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            // Saved number 1
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            number += 0;
            s = number.ToString();
            richTextBox1.AppendText(s);
        }
    }
}
