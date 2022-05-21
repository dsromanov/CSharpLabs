using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace lab1csharp
{
    public class Gift : IGift
    {
        private ICollection<Sweet> items;

        public Gift()
        {
            items = new List<Sweet>();
        }

        public void Add(Sweet sweets)
        {
            items.Add(sweets);
        }

        public int GiftWeight()
        {
            return items.Sum(x => x.Weight);
            
        }

        public void Sort()
        {
            var temp = items.OrderBy(x => x.Weight).ToList();
            items.Clear();
            foreach (var item in temp)
            {
                items.Add(item);
            }
        }

        public IEnumerable<Sweet> FindCandyBySugar(int min, int max)
        {
            return items.Where(x => (x.Sugar >= min) && (x.Sugar <= max)).ToList();
        }

        public IEnumerable<Sweet> Items
        {
            get { return this.items; }
        }
    }
}
