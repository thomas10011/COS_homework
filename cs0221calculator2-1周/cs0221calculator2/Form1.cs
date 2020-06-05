using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs0221calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;
            double answer = 0;
            try
            {
                
                int op = comboBox1.SelectedIndex;
                switch (op)
                {
                    case 0:
                        answer = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                        break;
                    case 1:
                        answer = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                        break;
                    case 2:
                        answer = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                        break;
                    case 3:
                        answer = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                        break;
                    default:
                        label6.Text = "wrong oprator!";
                        label5.Text = "wrong!";
                        return;

                }
            }
            catch(OverflowException ep)
            {
                label5.Text = "wrong!";
                label6.Text = "the answer is overflowed!";
                return;
            }
            catch(FormatException ep)
            {
                label5.Text = "wrong!";
                label6.Text = "wrong ";
                return;
            }
            
            label5.Text = Convert.ToString(answer);
        }
    }
}
