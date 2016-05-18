using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0.0;
        String operation = "";
        bool operation_pressed = false;


        public Form1()
        {
            InitializeComponent();
        }

     

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                if((!result.Text.Contains(",")))
                    result.Text = result.Text + b.Text;
            }
            else
            result.Text = result.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
                 Button b = (Button)sender;
       

                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "x^":
                    Double x;
                    Double y;
                    x = value;
                    y = Double.Parse(result.Text);
                    result.Text = ((double)Math.Pow(x, y)).ToString();

                    break;
                case "sqrt":

                    result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
                    break;


                default:
                    break;

            }
            // operation_pressed = false;
          
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            equation.Text = "";
            result.Text = "0";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {


                case "0":
                    button15.PerformClick();
                    break;

                case "1":
                    button1.PerformClick();
                    break;

                case "2":
                    button2.PerformClick();
                    break;

                case "3":
                    button3.PerformClick();
                    break;

                case "4":
                    button4.PerformClick();
                    break;

                case "5":
                    button5.PerformClick();
                    break;

                case "6":
                    button6.PerformClick();
                    break;

                case "7":
                    button7.PerformClick();
                    break;

                case "8":
                    button8.PerformClick();
                    break;

                case "9":
                    button9.PerformClick();
                    break;
                case "=":
                    button16.PerformClick();
                    break;
                case "/":
                    button10.PerformClick();
                    break;
                case "*":
                    button11.PerformClick();
                    break;
                case "-":
                    button12.PerformClick();
                    break;
                case "+":
                    button13.PerformClick();
                    break;
                case ",":
                    button14.PerformClick();
                    break;

                default:
                    break;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if ((!result.Text.Contains("-")) && (result.Text == "0"))
            {
                result.Clear();
                result.Text = "-" + result.Text;
            }

            else
            {

                result.Text = (-(Double.Parse(result.Text))).ToString();
            }
        }
    }
}
