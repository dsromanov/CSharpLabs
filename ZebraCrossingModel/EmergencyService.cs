using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZebraCrossingModel
{
    public class EmergencyService : ModelActingElement
    {
        private List<Car> trolleys;
        private Car brokenTrolley;

        public List<Car> Trolleys { get { return trolleys; } set { trolleys = value; } }

        public EmergencyService(Action<string> notification, List<Car> cars, Point point) : base(notification)
        {
            this.Point = point;
            this.trolleys = cars;
        }

        private void RepairTrolley()
        {
            Point defaultPoint = this.Point;
            OneWayTrace trace;
            if (brokenTrolley != null)
                lock (trolleys)
                {
                    trace = new OneWayTrace(this.Point, new Point(brokenTrolley.Point.X + 100, brokenTrolley.Point.Y + 50));
                    while (!trace.IsFinished)
                    {
                        this.Point = trace.NextPoint(this.Point);
                        Task.Delay(200).Wait();
                    }
                    brokenTrolley.Repair();
                }
            trace = new OneWayTrace(this.Point, defaultPoint);
            while (!trace.IsFinished)
            {
                this.Point = trace.NextPoint(this.Point);
                Task.Delay(200).Wait();
            }
            IsLocked = false;
            elemAction = null;
        }

        protected override void CheckEvents()
        {
            if (!IsLocked)
            {
                lock (trolleys)
                {
                    brokenTrolley = trolleys.FirstOrDefault
                        (trolley => trolley.IsBroken && !trolley.EmergencyAppointed);
                }
                if (brokenTrolley != null)
                {
                    brokenTrolley.EmergencyAppointed = true;
                    IsLocked = true;
                    Notification($"Аварийная служба отправлена на ремонт машины номер {brokenTrolley.Number}");
                    elemAction = RepairTrolley;
                }

            }
        }
    }
}
