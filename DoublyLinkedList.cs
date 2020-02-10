using System;
using System.Collections;
using System.Collections.Generic;

namespace practice
{
    public class DoublyLinkedList<T> : IDoublyLinkedList<T>
    {
        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node<T> Previous { get; set; }
        }
        private int _length = 0;
        private Node<T> _root = null;
        private Node<T> _head = null;

        public void Append(T value)
        {
            var node = new Node<T>();
            node.Value = value;
            if (_root is null)
            {
                _root = _head = node;
            }
            else
            {
                node.Previous = _head;
                _head.Next = node;
                _head = node;
            }
            _length += 1;
        }

        public void InsertTo(int index, T value)
        {
            if (index > _length || index < 0)
                throw new IndexOutOfRangeException();
            
            if (index == _length)
                Append(value);
            else
            {
                var newNode = new Node<T>();
                newNode.Value = value;

                if (index == 0)
                {
                    _root.Previous = newNode;
                    newNode.Next = _root;
                    _root = newNode;
                }
                else
                {
                    var curIndex = 0;
                    var prevNode = _root;
                    while (curIndex < index - 1)
                    {
                        prevNode = prevNode.Next;
                        curIndex += 1;
                    }
                    prevNode.Next.Previous = newNode;
                    newNode.Previous = prevNode;
                    newNode.Next = prevNode.Next;
                    prevNode.Next = newNode;
                }
                _length += 1;
            }
        }

        public void Remove(T value)
        {
            if (_root == null)
                return;
            if (_root.Value.Equals(value))
            {
                if(_root.Next == null){
                    _root = _head = null;
                }
                else {
                    _root = _root.Next;
                    _root.Previous = null;
                }
                _length -= 1;
                return;
            }
            var node = _root;
            while (node.Next != null)
            {
                if (node.Next.Value.Equals(value))
                {
                    if (node.Next == _head)
                        _head = node;
                    else
                        node.Next.Next.Previous = node;
                    node.Next = node.Next.Next;
                    _length -= 1;
                    return;
                }
                node = node.Next;
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= _length || index < 0)
                throw new IndexOutOfRangeException();
            
            if (index == 0)
            {
                _root = _root.Next;
                if (_root is null)
                    _head = null;
                else
                    _root.Previous = null;
                _length -= 1;
                return;
            }

            var curIndex = 0;
            var node = _root;
            while (curIndex < index - 1)
            {
                node = node.Next;
                curIndex += 1;
            }
            if (node.Next == _head)
                _head = node;
            else
                node.Next.Next.Previous = node;
            node.Next = node.Next.Next;

            _length -= 1;
        }

        public IEnumerable<T> Reverse()
        {
            var node = _head;
            if (node is null)
                yield break;
            do
            {
                yield return node.Value;
                node = node.Previous;
            } while (node != null);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = _root;
            if (node is null)
                yield break;
            do
            {
                yield return node.Value;
                node = node.Next;
            } while (node != null);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Length => _length;

        public override string ToString()
        {
            var head = _head == null ? null : _head.Value.ToString();
            var root = _root == null ? null : _root.Value.ToString();
            var items = string.Join(", ", this);
            var reverse = string.Join(", ", this.Reverse());
            return $"Root: {root}, Head: {head}, Length: {_length}, Items: {items}, Reverse: {reverse}";
        } 
    }

    public interface IDoublyLinkedList<T> : IEnumerable<T>
    {
        void Append(T value);
        void InsertTo(int index, T value);
        void Remove(T value);
        void RemoveAt(int index);
        int Length { get; }
    }
}