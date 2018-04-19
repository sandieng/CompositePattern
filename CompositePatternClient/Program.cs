using System;
using CompositePattern;

namespace CompositePatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("Pancake House Menu", "Breakfast");
            MenuComponent dinerMenu = new Menu("Diner Menu", "Lunch");
            MenuComponent cafeMenu = new Menu("Cafe Menu", "Dinner");
            MenuComponent dessertMenu = new Menu("Dessert Menu", "Dessert");
            MenuComponent allMenus = new Menu("All Menus", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            // Add menu items to diner menu
            dinerMenu.Add(new MenuItem("Pasta Cucianna", "Spaghetti with rinso sauce and mixed seafood", false, 20.95));
            dinerMenu.Add(new MenuItem("Chow Mian", "Smelly fried noodle with smelly tofu", true, 14.95));

            // Add dessert menu
            dessertMenu.Add(new MenuItem("Gelato", "Non diary gelato of the day", true, 4.50));
            dessertMenu.Add(new MenuItem("Snow ice campur", "Shaved ice with beans and fruits", true, 4.50));

            // Add dessert to diner menu
            dinerMenu.Add(dessertMenu);

            Waitress waitress = new Waitress(allMenus);
            waitress.Print();

            Console.ReadKey();
        }
    }
}
