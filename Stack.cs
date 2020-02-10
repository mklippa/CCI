namespace practice
{
    public class Stack<T> : IStack<T>
    {
        private ISinglyLinkedList<T> _linkedList = new SinglyLinkedList<T>();
        public int Length => _linkedList.Length;

        public T Pop()
        {
            // bad approach, O(N) 
            return _linkedList.RemoveAt(_linkedList.Length - 1);
        }

        public void Push(T value)
        {
            _linkedList.Append(value);
        }
    }

    public interface IStack<T>
    {
        void Push(T value);
        T Pop();
        int Length { get; }
    }
}