using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //вычесление
        private void button2_Click(object sender, EventArgs e)
        {
            
        
            double a, b, c, P, Pp, S;

           a = Convert.ToDouble(textBox1.Text);
           b = Convert.ToDouble(textBox2.Text);
           c = Convert.ToDouble(textBox3.Text);

            //проверка условия 
            if (a > 0 && b > 0 && c > 0) {
                if (a + b > c && a + c > b && b + c > a) {

                   //перимтр треугольника
                   P = a + b + c;

                   //полуперимтр треугольника
                   Pp = P / 2;

                   //формула нахождения площади
                   S = Math.Sqrt(Pp * (Pp - a) * (Pp - b) * (Pp - c));

                   //textBox4 вывод значения периметра треугольника
                   textBox4.Text = Convert.ToString(P);
                    //textBox4 вывод значения площади треугольника
                    textBox5.Text = Convert.ToString(S);

                } else {
                    
                }

            } else {
                
            }
            

        }

        //exit buttom
        private void button1_Click(object sender, EventArgs e)
        {
            //закрытие приложения
            Close();
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
