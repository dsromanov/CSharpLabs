using System;
using System.Collections.Generic;
using System.Text;

namespace lab1csharp
{
    public abstract class Sweet
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Sugar { get; set; }
        public int Calories { get; set; }

        public Sweet(string sweetName, int sweetWeight, int sweetSugar, int sweetCalories)
        {
            this.Name = sweetName;
            this.Weight = sweetWeight;
            this.Sugar = sweetSugar;
            this.Calories = sweetCalories;
        }
        public abstract void TypeSweet();
    }   
}
