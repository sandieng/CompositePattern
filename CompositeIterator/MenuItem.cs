using System;
using System.Collections.Generic;

namespace CompositeIterator
{
    public sealed class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public override void Print()
        {
            Console.Write($"  {Name}");
            if (IsVegetarian)
            {
                Console.Write(" (v)");
            }
            Console.WriteLine($", {Price}");
            Console.WriteLine($"   -- {Description}");
        }

        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            yield break;
        }
    }
}
