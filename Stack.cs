using System;

namespace practice
{
    public class Stack<T>
    {
        private ArrayList<T> _list = new ArrayList<T>();
        public uint Length => _list.Length;

        public T Pop()
        {
            if (Length == 0)
                throw new InvalidOperationException();
            var res = _list.Get(_list.Length - 1);
            _list.Get(_list.Length - 1);
            return res;
        }

        public void Push(T value)
        {
            _list.Add(value);
        }
    }
}