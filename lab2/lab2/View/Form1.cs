using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lab2sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<University> universities = new List<University>();
        public List<SecondUniversity> secondUniversities = new List<SecondUniversity>();

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            textBox4.Visible = false;
        }
        private int c1=0,c2=0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                secondUniversities.Add(new SecondUniversity(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)));
                textBox5.Text += (secondUniversities[c2].info() + Environment.NewLine + "Qp = " + secondUniversities[c2].quality() + Environment.NewLine);
                c2++;
            } else {
                universities.Add(new University(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
                textBox5.Text += (universities[c1].info() + Environment.NewLine + "Q = " + universities[c1].quality() + Environment.NewLine);
                c1++;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Visible = true;
                textBox4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
