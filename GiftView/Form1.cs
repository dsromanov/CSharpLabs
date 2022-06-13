using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1csharp;
namespace GiftView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IGift gift = new Gift();
        private void Form1_Load(object sender, EventArgs e)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new CandyCreator();
            creators[1] = new ChocolateCreator();

            

            foreach (Creator i in creators)
            {
                if (i is CandyCreator)
                {
                    gift.Add(i.FactoryMethod("M&M", 80, 105, 125, TypeCandy.Lollipop));
                    gift.Add(i.FactoryMethod("ChupaChups", 25, 75, 70, TypeCandy.Lollipop));
                    gift.Add(i.FactoryMethod("Коровка", 10, 30, 50, TypeCandy.ChocolateCandy));
                }

                if (i is ChocolateCreator)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 100, 115, 250, ChocolateColor.WhiteChocolate));
                    gift.Add(i.FactoryMethod("Бабаевский", 90, 150, 220, ChocolateColor.BlackChocolate));
                }
            }

            gift.Sort();
            textBox1.Text = "Отсортированный набор конфет: "+ Environment.NewLine;
            foreach (var i in gift.Items)
            {
                textBox1.Text += ("Название конфеты: " + i.Name + " Вес конфеты: " + i.Weight + " Сахар: " + i.Sugar + " Калории: " + i.Calories) + Environment.NewLine;
            }
            
            

            textBox1.Text += Environment.NewLine + ("Вес подарка: " + gift.GiftWeight());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (textBox3.Text.Length != 0 && textBox4.Text.Length != 0)
                foreach (var items in gift.FindCandyBySugar(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)))
                {
                textBox2.Text += ("Название конфеты: " + items.Name + " Сахар: " + items.Sugar)+ Environment.NewLine;
                }
            else
            {
                MessageBox.Show("Вы не ввели границы");
            }
        }
    }
}
