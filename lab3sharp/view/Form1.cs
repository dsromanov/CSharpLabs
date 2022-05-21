using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            label4.Visible = false;
            textBox2.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            label6.Visible = false;
            checkBox3.Visible = false;
            textBox5.Visible = false;
            label7.Visible = false;
            textBox6.Visible = false;
        }
        List<Figure> figures = new List<Figure>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                label4.Visible = true;
                textBox2.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                label6.Visible = true;
                checkBox3.Visible = true;
                textBox5.Visible = true;
                label7.Visible = true;
                textBox6.Visible = true;
                if (checkBox3.Checked)
                {
                    figures.Add(new Figure)
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox2.CheckState = CheckState.Unchecked;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                checkBox1.CheckState = CheckState.Unchecked;

        }
    }
}
