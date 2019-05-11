using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class TriangleTask : Form
    {
        public TriangleTask()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);
                string isTriangle = "Числата не могат да са дължини на страните на триъгълник.";
                string biggestNumber = "A";

                if (a < b)
                {
                    biggestNumber = "B";

                    if (c > b)
                    {
                        biggestNumber = "C";
                    }
                    else if (c == b)
                    {
                        biggestNumber = "B и C";
                    }

                }
                else if (a == b)
                {
                    if (a > c)
                    {
                        biggestNumber = "A и B";
                    }
                    else if (a == c)
                    {
                        biggestNumber = "A и B и C";
                    }
                    else
                    {
                        biggestNumber = "C";
                    }
                }
                else
                {
                    if (c > a)
                    {
                        biggestNumber = "C";
                    }
                    else if (a == c)
                    {
                        biggestNumber = "A и C";
                    }
                }

                if (a < b + c && b < a + c && c < a + b &&
                    a > c - b && b > c - a && c > b - a)
                {
                    isTriangle = "Числата могат да са дължини на страните на триъгълник.";
                }

                label4.Text = "Най-голямото число е " + biggestNumber + (biggestNumber.Length > 1 ? " и са равни. " : ". ") + isTriangle;
            }
            catch(Exception ex)
            {
                label4.Text = ex.Message;
            }
            

        }

    }
}
