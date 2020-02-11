using System;
using System.Collections;
using System.Collections.Generic;

namespace practice {
    public class ArrayList<T> : IEnumerable<T>
    {
        private T[] _arr = new T[1];

        private uint _length = 0;

        public uint Length => _length;

        public void Add(T value){
            if (_length == _arr.Length) {
                Increase();
            }
            _arr[_length] = value;
            _length += 1;
        }

        public void RemoveAt(uint index){
            if (index >= _length)
                throw new IndexOutOfRangeException();
            for (var i = index; i < _length - 1; i++)
                _arr[i] = _arr[i + 1];
            _length--;
        }

        public T Get(uint index) {
            if (index >= _length)
                throw new IndexOutOfRangeException();
            return _arr[index];
        }

        private void Increase() {
            var newArr = new T[_arr.Length * 2];
            for (int i = 0; i < _length; i++)
            {
                newArr[i] = _arr[i];
            }
            _arr = newArr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < _length; i++)
            {
                yield return _arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString() {
            return $"{string.Join(", ", this)}, Length: {_length}";
        }
    }
}