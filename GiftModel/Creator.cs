using System;
using System.Collections.Generic;
using System.Text;

namespace lab1csharp
{
    public abstract class Creator
    {
        public abstract Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, TypeCandy type);
        public abstract Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, ChocolateColor color);
    }
}
