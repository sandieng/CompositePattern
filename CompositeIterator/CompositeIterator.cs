using System;
using System.Collections;

namespace CompositeIterator
{
    public class CompositeIterator : IEnumerator
    {
        private readonly Stack _stack  = new Stack();

        public CompositeIterator(IEnumerator iterator)
        {
            _stack.Push(iterator);
        }

        public object Next()
        {
            if (HasNext())
            {
                IEnumerator iterator = (IEnumerator) _stack.Peek();
                MenuComponent component = (MenuComponent) iterator.Current;
                if (component is Menu)
                {
                    _stack.Push(component.CreateIterator());
                }

                return component;
            }

            return null;
        }

        public bool HasNext()
        {
            if (_stack.Count == 0)
            {
                return false;
            }

            IEnumerator iterator = (IEnumerator) _stack.Peek();
            if (!iterator.MoveNext())
            {
                _stack.Pop();
                return false;
            }

            return true;
        }

        public void Remove()
        {
            throw new NotSupportedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current { get; }
    }
}
