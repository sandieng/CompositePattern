using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositeIterator
{
    public sealed class Menu : MenuComponent
    {
        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override void Print()
        {
            Console.Write($"\n {Name}");
            Console.WriteLine($", {Description}");
            Console.WriteLine("-------------------------------------------------------------------------------");

            //            IEnumerator iterator = _menuComponents.GetEnumerator();
            //            while (iterator.MoveNext())
            //            {
            //                MenuComponent menuComponent = (MenuComponent) iterator.Current;
            //                menuComponent.Print();
            //            }

            // Or simply use this
            foreach (var menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }

        public MenuComponent GetChild(string name)
        {
            return _menuComponents.Find(x => x.Name == name);
        }

        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            var components = new Stack<MenuComponent>(new[] { this });
            while (components.Any())
            {
                MenuComponent component = components.Pop();
                yield return component;
                if (component is Menu menu)
                {
                    foreach (var n in menu._menuComponents) components.Push(n);
                }
            }
        }
    }
}
