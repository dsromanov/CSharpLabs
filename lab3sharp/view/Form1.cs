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
        }
        List<Figure> figures = new List<Figure>();
        Rhomb rhomb = new Rhomb(2, 4, 4, "black", 10, 60);
        string color="";
        public void output()
        {
            listBox1.Items.Clear();
            foreach (Rhomb rhomb in figures)
            {
                listBox1.Items.Add("Ромб " + rhomb.nPlane + " " + rhomb.angles + " " + rhomb.sides + " " + rhomb.color + " " + rhomb.sideLength + " " + rhomb.closeAngle);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            figures.Add(new Rhomb(2, 4, 4, color, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)));
            rhomb = new Rhomb(2, 4, 4, color, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            output();
            color = "";
        }


       

        private void button2_Click(object sender, EventArgs e)
        {
            rhomb.draw();
            MessageBox.Show("Вы нарисовали фигуру");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rhomb.erase();
            MessageBox.Show("Вы стерли фигуру");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                figures.RemoveAt(listBox1.SelectedIndex);
                output();
            }
            else
            {
                MessageBox.Show("Добавьте хотя бы 1 элемент");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rhomb.P();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rhomb.S();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog2.Color.ToString();
            }
            rhomb.changeColor(color);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            rhomb.draw();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            rhomb.erase();
        }
    }
}
