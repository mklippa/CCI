using System;

namespace practice{
    public class Queue<T> {
        private SinglyLinkedList<T> _list = new SinglyLinkedList<T>();
        public uint Length => (uint)_list.Length;
        public void Enqueue(T value){
            _list.Append(value);
        }
        public T Dequeue(){
            if (Length == 0)
                throw new InvalidOperationException();
            return _list.RemoveAt(0);
        }

        public override string ToString() {
            return $"{string.Join(", ", _list)}, Length: {Length}";
        }
    }
}