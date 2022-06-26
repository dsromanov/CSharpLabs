using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZebraCrossingModel
{
    public class OneWayTrace : ElemTrace
    {
        private bool isFinished;

        public bool IsFinished { get { return isFinished; } }

        public OneWayTrace(Point fromPoint, Point toPoint) : base(fromPoint, toPoint)
        {
            isFinished = false;
        }

        public override Point NextPoint(Point point)
        {
            int signX = Math.Sign(toPoint.X - fromPoint.X);
            int signY = Math.Sign(toPoint.Y - fromPoint.Y);

            int newX = point.X + signX * stepX;
            int newY = point.Y + signY * stepY;

            Point newPoint = new Point(newX, newY);
            isFinished = (Distance(newPoint, toPoint) < (stepX + stepY));
            return newPoint;
        }
    }
}
