using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3MIDPS
{
     public partial class Form1 : Form
     {
          bool plus = false;
          bool minus = false;
          bool inm = false;
          bool imp = false;
          public Form1()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               textBox1.Text = textBox1.Text + "7";
          }


          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }

          private void button2_Click(object sender, EventArgs e)
          {
               textBox1.Text = textBox1.Text + "8";
          }

          private void button3_Click_1(object sender, EventArgs e)
          {
               textBox1.Text = textBox1.Text + "9";
          }

          private void button4_Click(object sender, EventArgs e)
          {
               textBox1.Text = textBox1.Text + "4";
          }

          private void button5_Click(object sender, EventArgs e)
          {
               textBox1.Text = textBox1.Text + "5";
          }

          private void button6_Click(object sender, EventArgs e)
          {
               textBox1.Text = textBox1.Text + "6";
          }

          private void button7_Click(object sender, EventArgs e)
          {
               textBox1.Text = textBox1.Text + "1";
          }

          private void button8_Click(object sender, EventArgs e)
          {
               textBox1.Text = textBox1.Text + "2";
          }

          private void button9_Click(object sender, EventArgs e)
          {
               textBox1.Text = textBox1.Text + "3";
          }

          private void button10_Click(object sender, EventArgs e)
          {
               textBox1.Text = textBox1.Text + "0";
          }

          private void button19_Click(object sender, EventArgs e)
          {
               textBox1.Text = "";
               textBox1.Tag = "";
          }

          private void button17_Click(object sender, EventArgs e)
          {
               if (textBox1.Text != "")
               {
                    double x;
                    x = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(x);
               }
               else
               {
                    return;
               }
          }

          private void button16_Click(object sender, EventArgs e)
          {
               if (textBox1.Text != "") 
               {
                    double k;
                    k = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(Math.Sqrt(k));
               }
               else
               {
                    return;
               }
          }

          private void button15_Click(object sender, EventArgs e)
          {
               plus = true;
               textBox1.Tag = textBox1.Text;
               textBox1.Text = "";
          }

          private void button14_Click(object sender, EventArgs e)
          {
               minus = true;
               textBox1.Tag = textBox1.Text;
               textBox1.Text = "";
          }

          private void button13_Click(object sender, EventArgs e)
          {
               inm = true;
               textBox1.Tag = textBox1.Text;
               textBox1.Text = "";
          }

          private void button12_Click(object sender, EventArgs e)
          {
               imp = true;
               textBox1.Tag = textBox1.Text;
               textBox1.Text = "";
          }

          private void button18_Click(object sender, EventArgs e)
          {
               if (plus)
               {
                    decimal d = Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox1.Tag);
                    textBox1.Text = d.ToString();
               } if (minus)

               {
                    decimal d = Convert.ToDecimal(textBox1.Text) - Convert.ToDecimal(textBox1.Tag);
                    textBox1.Text = d.ToString();
               }
               if (inm)
               {
                    decimal d = Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Tag);
                    textBox1.Text = d.ToString();
               }
               if (imp)
               {
                    decimal d = Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(textBox1.Tag);
                    textBox1.Text = d.ToString();
               }
          }

          private void button11_Click(object sender, EventArgs e)
          {
               textBox1.Text += ".";
          }
     }
}
