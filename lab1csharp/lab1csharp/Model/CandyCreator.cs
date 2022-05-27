using System;
using System.Collections.Generic;
using System.Text;

namespace lab1csharp
{
    public class CandyCreator : Creator
    {
        public override Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, TypeCandy type)
        {
            return new Candy(candyName, candyWeight, candySugar, candyCalories, type);
        }
        public override Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, ChocolateColor color)
        {
            throw new NotImplementedException();
        }

    }
}
