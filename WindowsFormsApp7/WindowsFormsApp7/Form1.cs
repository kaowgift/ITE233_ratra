using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        string input = string.Empty; //String collect user input
        string ope1 = string.Empty; //string collect first input
        string ope2 = string.Empty; //string collect second input
        char operation; //char for operation
        double result = 0.0; //calculated result
        Boolean equal_c = false;
        Boolean ope_c = false;
        double memo_store;


        public Form1()
        {
            InitializeComponent();
        }
        public void check_equal()
        {
            if(equal_c == true && ope_c == false)
            {
                textBox1.Text = "";
                this.input = string.Empty;
                this.ope1 = string.Empty;
                this.ope2 = string.Empty;
               
            }
            equal_c = false;
        }
        public void ope_check()
        {
            if(ope_c == true)
            {
                ope2 = input;
                double n1;
                double n2;
                double.TryParse(ope1, out n1);
                double.TryParse(ope2, out n2);

                if (operation == '+')
                {
                    result = n1 + n2;
                    textBox1.Text = result.ToString();
                }
                else if (operation == '-')
                {
                    result = n1 - n2;
                    textBox1.Text = result.ToString();

                }
                else if (operation == '*')
                {
                    result = n1 * n2;
                    textBox1.Text = result.ToString();
                }
                else if (operation == '%')
                {
                    result = n1 % n2;
                    textBox1.Text = result.ToString();
                }
                else if (operation == '2')
                {
                    
                    result = Math.Pow(n2, 2);
                    textBox1.Text = n2.ToString();
                }
                else if (operation == '3')
                {

                    result = Math.Pow(n2, 3);
                    textBox1.Text = n2.ToString();
                }
                else if (operation == 'x')
                {

                    result = Math.Pow(10, n2);
                    textBox1.Text = result.ToString();
                }
                else if (operation == 'y')
                {

                    result = Math.Pow(n1, n2);
                    textBox1.Text = result.ToString();
                }
                else if (operation == 'e')
                {

                    result = Math.Exp(n2);
                    textBox1.Text = result.ToString();
                }
                else if (operation == '/')

                {
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "DIV/Zero";
                    }





                }
                input = result.ToString();
                //equal_c = true;
            }
            ope_c = false;
            
        }





        private void nine_Click(object sender, EventArgs e)
        {
            
            
            check_equal();

            //receive the number
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
            equal_c = false;
            //MessageBox.Show(ope1 + "  " + ope2);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            
            check_equal();

            //receive the number
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
            equal_c = false;
            //MessageBox.Show(ope1 + "  " + ope2);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            check_equal();

            //receive the number
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
            equal_c = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            check_equal();

            //receive the number
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
            equal_c = false;

        }
        private void five_Click(object sender, EventArgs e)
        {
            check_equal();

            //receive the number
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
            equal_c = false;
        }

        private void four_Click(object sender, EventArgs e)
        {
            check_equal();

            //receive the number
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
            equal_c = false;
        }

        private void three_Click(object sender, EventArgs e)
        {
            check_equal();

            //receive the number
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
            equal_c = false;

        }

        private void two_Click(object sender, EventArgs e)
        {

            check_equal();
           
            //receive the number
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
            equal_c = false;
        }

        private void one_Click(object sender, EventArgs e)
        {
            check_equal();

            //receive the number
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
            equal_c = false;

        }

        private void zero_Click(object sender, EventArgs e)
        {
            check_equal();

            //receive the number
            this.textBox1.Text = "";
            input += "0";

            this.textBox1.Text += input;
            equal_c = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //Clear all data that user input
           textBox1.Text = "";
            /*this.input = string.Empty;
            this.ope1 = string.Empty;
            this.ope2 = string.Empty;
            ope_c = false;
            */
            input = string.Empty; //String collect user input
            ope1 = string.Empty; //string collect first input
            ope2 = string.Empty; //string collect second input
            
            result = 0.0; //calculated result
            equal_c = true;
            ope_c = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            ope_check();
            //equal_c = false;
            ope1 = input;
            operation = '*';
            input = string.Empty;
            ope_c = true;
            //multiply
           
        }

        private void plus_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ope1 + "  " + ope2); show data that got
            ope_check();
            //equal_c = false;
            ope1 = input;
            operation = '+';
            input = string.Empty;
            ope_c = true;
            //MessageBox.Show(ope1 + "  " + ope2);

        }

        private void minus_Click(object sender, EventArgs e)
        {
            
            ope_check();
            //equal_c = false;
            ope1 = input;
            operation = '-';
            input = string.Empty;
            ope_c = true;

        }

        private void divide_Click(object sender, EventArgs e)
        {
            
            ope_check();
            //equal_c = false;
            ope1 = input;
            operation = '/';
            input = string.Empty;
            ope_c = true;

        }
        private void mod_button_Click(object sender, EventArgs e)
        {
            ope_check();
            //equal_c = false;
            ope1 = input;
            operation = '%';
            input = string.Empty;
            ope_c = true;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void equals_Click(object sender, EventArgs e)
        {

            ope2 = input;
            double n1;
            double n2;
            
            
            double.TryParse(ope1, out n1);
            double.TryParse(ope2, out n2);
            
            if (operation == '+')
            {
                result = n1 + n2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = n1 - n2;
                textBox1.Text = result.ToString();

            }
            else if (operation == '*')
            {
                result = n1 * n2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '%')
            {
                result = n1 % n2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '2')
            {
               
                result = Math.Pow(n2, 2);
                textBox1.Text = n2.ToString();
            }
            else if (operation == '3')
            {

                result = Math.Pow(n2, 3);
                textBox1.Text = n2.ToString();
            }
            else if (operation == 'x')
            {

                result = Math.Pow(10, n2);
                textBox1.Text = result.ToString();
            }
            else if (operation == 'y')
            {

                result = Math.Pow(n1, n2);
                textBox1.Text = result.ToString();
            }
            else if (operation == 'e')
            {

                result = Math.Exp(n2);
                textBox1.Text = result.ToString();
            }

            else if (operation == '/')
            {
                if (n2 != 0)
                {
                    result = n1 / n2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero";
                }
            
                


            

            }
            //ope1 = Convert.ToString(result);
            operation = '\0';
            input = result.ToString();
            equal_c = true;
            ope_c = false;
            ope1 = textBox1.Text;





        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dot_button_Click(object sender, EventArgs e)
        {
            check_equal();
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input ;
            equal_c = false;


        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            
                string dele = Remove(textBox1.Text);
                input = dele;
                textBox1.Text = dele;
            

            





        }
        public string Remove(string N)
        {
            string dele = string.Empty;
            char[] text = N.ToCharArray();
            for (int i = 0; i < text.Length - 1; i++)
            {
                dele += text[i];
            }
            return dele;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {

        }

        private void exp_button_Click(object sender, EventArgs e)
        {
            ope_c = true;
            operation = 'e';
            ope_check();
            ope1 = input;

            operation = 'e';
            textBox1.Text = result.ToString();
            //input = string.Empty;
            //check_equal();

            ope_c = true;
            equal_c = true;
        }

        private void button4_Click(object sender, EventArgs e)
        //x^2
        {
            ope_c = true;
            operation = '2';
            ope_check();
            ope1 = input;
            
            operation = '2';
            textBox1.Text = result.ToString();
            //input = string.Empty;
            //check_equal();
            
            ope_c = true;
            equal_c = true;


        }
        private void expo3_button_Click(object sender, EventArgs e)
        {
            ope_c = true;
            operation = '3';
            ope_check();
            ope1 = input;
            operation = '3';
            textBox1.Text = result.ToString();
            //input = string.Empty;
            //check_equal();

            ope_c = true;
            equal_c = true;
        }
        private void expo10_x_button_Click(object sender, EventArgs e)
        {
            ope_c = true;
            operation = 'x';
            ope_check();
            ope1 = input;
            operation = 'x';
            textBox1.Text = result.ToString();
            //input = string.Empty;
            //check_equal();
            ope_c = true;
            equal_c = true;
        }
        private void expo_y_button_Click(object sender, EventArgs e)
        {
            ope_check();
            //equal_c = false;
            ope1 = input;
            operation = 'y';
            input = string.Empty;
            ope_c = true;
           
            



        }

        private void clear_e_button_Click(object sender, EventArgs e)
        {
            //Clear all data that user input
            textBox1.Text = "";
            this.input = string.Empty;
            this.ope1 = string.Empty;
            this.ope2 = string.Empty;
        }

        

        private void dividenumber_button_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mc_button_Click(object sender, EventArgs e)
        {
            memo_text.Clear();
            memo_store = 0;
            memo_text.Text = "Nothing stored in Memery";
        }

        private void m_plus_buttom_Click(object sender, EventArgs e)
        {
            double nump1;
            double.TryParse(textBox1.Text, out nump1);
            if (nump1 != 0 && equal_c == false)
            {
                memo_store += nump1;
            }
            else
            {
                memo_store += result;
            }
            memo_text.Text = Convert.ToString(memo_store);
            
        }

        private void m_minus_buttom_Click(object sender, EventArgs e)
        {
            double nump1;
            double.TryParse(textBox1.Text, out nump1);
            if (nump1 != 0 && equal_c == false)
            {
                memo_store -= nump1;
            }
            else
            {
                memo_store -= result;
            }
            memo_text.Text = Convert.ToString(memo_store);
         
        }

        private void memo_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void convertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            binaryconverter f2 = new binaryconverter();
            f2.ShowDialog();
            this.Enabled = true;
        }
    }
}
