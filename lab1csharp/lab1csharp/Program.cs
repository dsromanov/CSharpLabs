using System;

namespace lab1csharp
{

    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new CandyCreator();
            creators[1] = new ChocolateCreator();

            IGift gift = new Gift();

            foreach (Creator i in creators)
            {
                if (i is CandyCreator)
                {
                    gift.Add(i.FactoryMethod("M&M", 80, 105, 125, TypeCandy.Lollipop));
                    gift.Add(i.FactoryMethod("ChupaChups", 25, 75, 70, TypeCandy.Lollipop));
                }

                if (i is ChocolateCreator)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 100, 115, 250, ChocolateColor.WhiteChocolate));
                }
            }

            gift.Sort();
            gift.ShowItems();

            Console.WriteLine();
            foreach (var items in gift.FindCandyBySugar(20, 110))
            {
                Console.WriteLine("Название конфеты: {0}, Сахар: {1}", items.Name, items.Sugar);
            }

            Console.WriteLine();
            Console.WriteLine("Вес подарка: {0}", gift.GiftWeight());
            Console.ReadKey();
        }
    }
}
