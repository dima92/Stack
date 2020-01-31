using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack.Model
{
    public class EasyStack<T> : ICloneable
    {
        private List<T> _items = new List<T>();

        public int Count => _items.Count;

        public bool IsEmpty => _items.Count == 0;

        public void Push(T item)
        {
            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear();
        }
        public T Peek()
        {
            if (!IsEmpty)
            {
                return _items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = _items.LastOrDefault();
                _items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public override string ToString()
        {
            return $"Стек с {Count} элементами";
        }

        public object Clone()
        {
            var newStack = new EasyStack<T>();
            newStack._items = new List<T>(_items);
            return newStack;
        }
    }
}
