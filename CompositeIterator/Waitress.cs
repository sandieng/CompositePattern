using System;

namespace CompositeIterator
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void Print()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("VEGATARIAN MENU");

            foreach (MenuComponent menuComponent in _allMenus)
            {
                try
                {
                    if (menuComponent.IsVegetarian)
                    {
                        menuComponent.Print();
                        Console.Write("\n");
                    }
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Operation not supported.");
                }
            }
        }
    }
}
