using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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

        public IEnumerator CreateIterator()
        {
            return new NullIterator();
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
    }
}
