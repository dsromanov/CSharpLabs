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
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.MeasureItem += lst_MeasureItem;
            this.listBox1.DrawItem += lst_DrawItem;
        }
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBox1.Items[e.Index].ToString(), listBox1.Font, listBox1.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        List<Figure> figures = new List<Figure>();
        Rhomb rhomb = new Rhomb(2, 4, 4, "black", 10, 60);
        string color="";
        public void output()
        {
            listBox1.Items.Clear();
            foreach (Rhomb rhomb in figures)
            {
                listBox1.Items.Add("Ромб: " + " Плоскость:" + rhomb.nPlane + " Сторон и углов:" + rhomb.angles + " " + rhomb.sides + Environment.NewLine + "Цвет:" + rhomb.color + " Длина стороны:" + rhomb.sideLength + " Меньший угол:" + rhomb.closeAngle);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            figures.Add(new Rhomb(2, 4, 4, color, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)));
            output();
            color = "";
        }


       

        private void button2_Click(object sender, EventArgs e)
        {
            figures[listBox1.SelectedIndex].draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            figures[listBox1.SelectedIndex].erase();
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
            ((Rhomb)figures[listBox1.SelectedIndex]).P();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ((Rhomb)figures[listBox1.SelectedIndex]).S();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog2.Color.ToString();
            }
            ((Rhomb)figures[listBox1.SelectedIndex]).changeColor(color);
            output();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ((Rhomb)figures[listBox1.SelectedIndex]).draw();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ((Rhomb)figures[listBox1.SelectedIndex]).erase();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
