using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeIterator
{
    public abstract class MenuComponent
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

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
