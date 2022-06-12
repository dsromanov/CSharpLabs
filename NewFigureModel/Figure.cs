using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lab4csharp
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
                MessageBox.Show("Вы нарисовали фигуру!");
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
        public Rhomb() : base(2, 4, 4, "")
        {
            this.sideLength = 0;
            this.closeAngle = 0;
        }
        public Rhomb(int nPlane, int angles, int sides, string color, int sideLength, int closeAngle) : base(nPlane, angles, sides, color)
        {
            this.sideLength = sideLength;
            this.closeAngle = closeAngle;
        }
        public void P()
        {
            MessageBox.Show("Периметр ромба: " + 4 * sideLength);
        }
        public void S()
        {
            MessageBox.Show("Площадь ромба: " + Math.Round(Math.Pow(sideLength,2)*Math.Sin((closeAngle/180D)*Math.PI),2));
        }
    } 
    public class Round : GeometricFigure
    {
        public int radius { get; set; }
        public Round() : base(2, 0, 0, "")
        {
            this.radius = 0;
        }
        public Round(int nPlane, int angles, int sides, string color, int radius) : base(nPlane, angles, sides, color)
        {
            this.radius = radius;
        }
        public void RoundLength()
        {
            MessageBox.Show("Длина окружности: " + Math.Round(2 * Math.PI * radius,2));
        }
        public void RoundS()
        {
            MessageBox.Show("Площадь круга: " + Math.Round(Math.PI * Math.Pow(radius, 2), 2));
        }
    }
    public class Square: GeometricFigure
    {
        public int sideLength { get; set; }
        public Square():base(2, 4, 4, "")
        {
            this.sideLength = 0;
        }
        public Square(int nPlane, int angles, int sides, string color, int side) : base(nPlane, angles, sides, color)
        {
            this.sideLength = side;
        }
        public void P()
        {
            MessageBox.Show("Периметр квадрата: " + 4 * sideLength);
        }
        public void S()
        {
            MessageBox.Show("Площадь квадрата: " + sideLength * sideLength);
        }
    }
}
