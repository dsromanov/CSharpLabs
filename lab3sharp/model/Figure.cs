using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lab3sharp
{
    public interface Figure
    {
        int nPlane { get; set; }
        void draw();
        void erase();
    }
    public abstract class GeometricFigure: Figure
    {
        public int nPlane { get; set; }
        public int angles { get; set; }
        public int sides { get; set; }
        public string color { get; set; }

        public GeometricFigure(int nPlane, int angles, int sides, string color)
        {
            this.nPlane = nPlane;
            this.angles = angles;
            this.sides =  sides;
            this.color = color;
        }
        public void draw()
        {
            if ((angles == sides && sides!=2) || (sides==1 && angles==0) || (sides==2 && angles==1))//проверка на фигуру: фигура угол или точка прямая
            {
                MessageBox.Show("Вы нарисовали фигуру!");
            }else
            {
                MessageBox.Show("Это не фигура!");
            }
        }
        public void erase()
        {
            angles = 0;
            sides = 0;
            MessageBox.Show("Вы стерли фигуру");
        }
        public void changeColor(string newColor)
        {
            this.color = newColor;
        }
    }
    public class Rhomb: GeometricFigure
    {
        public int sideLength { get; set; }
        public int closeAngle { get; set; }
        public Rhomb(int nPlane, int angles, int sides, string color, int sideLength, int closeAngle) : base(nPlane, angles, sides, color)
        {
            this.sideLength = sideLength;
            this.closeAngle = closeAngle;
        }
        public void P()
        {
            MessageBox.Show("Периметр: " + 4 * sideLength);
        }
        public void S()
        {
            MessageBox.Show("Площадь: " + Math.Pow(sideLength,2)*Math.Sin(closeAngle));
        }
    } 
}
