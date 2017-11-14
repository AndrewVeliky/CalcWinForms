using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        double a = 1;
        double b = 2;
        double c = 3;
        double d = 4;
        double u = 5;
        double f = 6;
        double g = 7;
        double h = 8;
        double p = 9;
        double k = 0;
        char m = ',';
        char l = '-';
        char q = '%';

        bool add = false;
        bool devide = false;
        bool multiple = false;
        bool subtract = false;
        bool perc = false;

        double firstNum;
        double secondNum;
        double equal;

        public Form1()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += Convert.ToString(g); 
            

        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(h);
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(p);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(d);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(u);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(f);
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(a);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(b);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(c);
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(k);
            
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(m);
        }

        private void button_plmin(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(l);
        }

        private void Button_percentage(object sender, EventArgs e)
        {
                perc = true;
            
                secondNum = Convert.ToDouble(textBox1.Text);
                secondNum = (firstNum * secondNum)/100;
                textBox1.Text = Convert.ToString(secondNum);
            
          
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            add = true;
            
            if (firstNum != Convert.ToDouble(textBox1.Text))
            {

                firstNum = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();

            }
            else
            {
                secondNum = Convert.ToDouble(textBox1.Text);
                firstNum = firstNum + secondNum;

                textBox1.Clear();
            }
        }

        private void button_devide_Click(object sender, EventArgs e)
        {
            devide = true;
            if (firstNum != Convert.ToDouble(textBox1.Text))
            {
                firstNum = Convert.ToDouble(textBox1.Text);

                textBox1.Clear();
            }
            else
            {
                secondNum = Convert.ToDouble(textBox1.Text);
                firstNum = firstNum/secondNum;

                textBox1.Clear();
            }

        }

        private void button_multiple_Click(object sender, EventArgs e)
        {
            multiple = true;
            if (firstNum != Convert.ToDouble(textBox1.Text))
            {
                firstNum = Convert.ToDouble(textBox1.Text);

                textBox1.Clear();
            }
            else
            {
                secondNum = Convert.ToDouble(textBox1.Text);
                firstNum = firstNum * secondNum;

                textBox1.Clear();
            }
        }

        private void Button_subtract_Click(object sender, EventArgs e)
        {
            subtract = true;
            if (firstNum != Convert.ToDouble(textBox1.Text))
            {
                firstNum = Convert.ToDouble(textBox1.Text);

                textBox1.Clear();
            }
            else
            {
                secondNum = Convert.ToDouble(textBox1.Text);
                firstNum = firstNum - secondNum;

                textBox1.Clear();
            }
        }

        

        private void Button_equal_Click(object sender, EventArgs e)
        {
            if (equal != Convert.ToDouble(textBox1.Text) || Convert.ToDouble(textBox1.Text)==0)
            {
                if (add == true)
                {
                    secondNum = Convert.ToDouble(textBox1.Text);
                    equal = firstNum + secondNum;
                    textBox1.Text = Convert.ToString(equal);
                    add = false;

                }

                else if (devide == true)
                {
                    secondNum = Convert.ToDouble(textBox1.Text);
                    equal = firstNum / secondNum;
                    textBox1.Text = Convert.ToString(equal);
                    devide = false;
                }

                else if (multiple == true)
                {
                    secondNum = Convert.ToDouble(textBox1.Text);
                    equal = firstNum * secondNum;
                    textBox1.Text = Convert.ToString(equal);
                    multiple = false;
                }

                else if (subtract == true)
                {
                    secondNum = Convert.ToDouble(textBox1.Text);
                    equal = firstNum - secondNum;
                    textBox1.Text = Convert.ToString(equal);
                    subtract = false;
                }
            }
            else 
            {
               
                equal = Convert.ToDouble(textBox1.Text);

            }
                
                
            
            


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
