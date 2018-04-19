using System;
using System.Collections;
using System.Collections.Generic;

namespace CompositeIterator
{
    public abstract class MenuComponent : IEnumerable<MenuComponent>
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual double Price { get; set; }

        public virtual bool IsVegetarian { get; set; }

        public abstract IEnumerator<MenuComponent> GetEnumerator();

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
