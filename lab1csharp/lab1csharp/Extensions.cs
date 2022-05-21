using System;
using System.Collections.Generic;
using System.Text;

namespace lab1csharp
{
    public static class Extensions
    {
        public static void ShowItems(this IGift gift)
        {
            Console.WriteLine("Набор конфет: ");
            foreach (var i in gift.Items)
            {
                Console.WriteLine("Название конфеты: {0}, Вес конфеты: {1}, Сахар: {2}, Калории: {3},"
                    , i.Name, i.Weight, i.Sugar, i.Calories);

            }

        }
    }
}
