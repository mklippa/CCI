using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace practice {
    public class HashTable<TKey, TValue> : IEnumerable<(TKey, TValue)>
    {
        private class KeyValue {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }
        private SinglyLinkedList<KeyValue>[] _arr = new SinglyLinkedList<KeyValue>[10];
        public uint Length { get; private set;} = 0;

        public void Add(TKey key, TValue value) 
        {
            var list = GetList(key);
            if (list.Any(item => item.Key.Equals(key)))
                throw new Exception("Duplicated key");
            list.Append(new KeyValue{Key=key,Value=value});
            Length++;
        }
        public TValue Get(TKey key) {
            var list = GetList(key);
            return list.First(item => item.Key.Equals(key)).Value;
            foreach (var item in list)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }
            throw new Exception("Key doesn't exist");
        }
        public void Remove(TKey key) {
            var list = GetList(key);
            var index = 0;
            foreach (var item in list)
            {
                if (item.Key.Equals(key))
                {
                    list.RemoveAt(index);
                    Length--;
                    return;
                }
                index++;
            }
            throw new Exception("Key doesn't exist");
        }

        private int GetIndex(TKey key) {
            return key.GetHashCode() % _arr.Length;
        }

        private SinglyLinkedList<KeyValue> GetList(TKey key) {
            if (_arr[GetIndex(key)] is null)
                _arr[GetIndex(key)] = new SinglyLinkedList<KeyValue>();
            return _arr[GetIndex(key)];
        }

        public IEnumerator<(TKey, TValue)> GetEnumerator()
        {
            foreach (var list in _arr)
            {
                foreach (var item in list)
                {
                    yield return (item.Key, item.Value);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString(){
            return string.Join(", ", this);
        }
    }
}