using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZebraCrossingModel
{
    public class Crosswalker : ModelActingElement
    {
        public string name;
        private Crosswalk crosswalk;
        private Car car;

        public string Name { get { return name; } }

        private Point GetCrosswalkPoint()
        {
            return new Point(crosswalk.Point.X, crosswalk.Point.Y);
        }

        public Crosswalker(string name, Crosswalk crosswalk, Car car, Action<string> notification) : base(notification)
        {
            this.name = name;
            this.crosswalk = crosswalk;
            this.car = car;
            this.Point = GetCrosswalkPoint();
        }

        private void Walk()
        {
            lock (crosswalk)
            {
                OneWayTrace trace = new OneWayTrace(this.Point, new Point(this.Point.X, this.Point.Y + 100));
                while (!trace.IsFinished)
                {
                    this.Point = trace.NextPoint(this.Point);
                    Task.Delay(200).Wait();
                }
                trace = new OneWayTrace(this.Point, new Point(this.Point.X, this.Point.Y - 100));
                while (!trace.IsFinished)
                {
                    this.Point = trace.NextPoint(this.Point);
                    Task.Delay(200).Wait();
                }
            }
            IsLocked = false;
            elemAction = null;
        }

        private bool IsNear()
        {
            return Math.Abs(car.Point.X - crosswalk.Point.X) <= 100;
        }

        protected override void CheckEvents()
        {
            if (!IsLocked && !IsNear())
            {
                car.IsLocked = true;
                elemAction = Walk;
                car.IsLocked = false;
            }   
            else
            {
                IsLocked = true;
                Task.Delay(200).Wait();
            }
        }
    }
}
