using System;
using System.Collections.Generic;
using System.Text;

namespace lab1csharp
{
    public class ChocolateCreator : Creator
    {
        public override Sweet FactoryMethod(string chocoName, int chocoWeight, int chocoSugar, int chocoCalories, ChocolateColor chocoColor)
        {
            return new Chocolate(chocoName, chocoWeight, chocoSugar, chocoCalories, chocoColor);
        }
        public override Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, TypeCandy type)
        {
            throw new NotImplementedException();
        }

    }
}
