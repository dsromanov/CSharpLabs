﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZebraCrossingModel
{
    public class CarTrace : ElemTrace
    {
        private bool moveFromTo;

        public CarTrace(Point fromPoint, Point toPoint) : base(fromPoint, toPoint)
        {
            moveFromTo = true;
            stepCount = 500;
        }

        public override Point NextPoint(Point point)
        {
            int signX = Math.Sign(toPoint.X - fromPoint.X);
            int signY = Math.Sign(toPoint.Y - fromPoint.Y);
            if (!moveFromTo)
            {
                signX = -signX;
                signY = -signY;
            }
            int newX = point.X + signX * stepX;
            int newY = point.Y + signY * stepY;
            Point newPoint = new Point(newX, newY);
            if (moveFromTo &&
                Distance(newPoint, toPoint) < (stepX + stepY))
                moveFromTo = false;
            else if (!moveFromTo &&
                Distance(newPoint, fromPoint) < (stepX + stepY))
                moveFromTo = true;
            return newPoint;
        }
    }
}
