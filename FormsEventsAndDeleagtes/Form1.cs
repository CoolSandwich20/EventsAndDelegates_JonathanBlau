using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEventsAndDeleagtes
{
    public partial class Form1 : Form
    {
        public delegate double Calculation(double x, double y);


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {

                Calculation calDel = null;
                switch (comboBox2.SelectedItem.ToString())
                {
                    case "+":
                        calDel = Add;
                        break;
                    case "-":
                        calDel = Subtract;
                        break;
                    case "*":
                        calDel = Multiply;
                        break;
                    case "/":
                        calDel = Divide;
                        break;
                    case "^":
                        calDel = Power;
                        break;
                    case "%":
                        calDel = Modolus;
                        break;
                }
                if (calDel != null)
                {
                    double res = calDel(num1, num2);
                    resultLabel.Text = res.ToString();
                }
                else
                {
                    resultLabel.Text = "Invalid Operation";
                }
            }
            else
            {
                resultLabel.Text = "Invalid Input";
            }


        }
        private static double Add(double x, double y) => x + y;
        private static double Subtract(double x, double y) => x - y;
        private static double Multiply(double x, double y) => x * y;
        private static double Divide(double x, double y) => x / y;
        private static double Power(double x, double y) => Math.Pow(x, y);
        private static double Modolus(double x, double y) => x % y;
        private void textBox1_Enter(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
