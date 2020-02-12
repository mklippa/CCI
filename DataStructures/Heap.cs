using System;
using System.Collections.Generic;
using System.Linq;

namespace practice {
    public class Heap {
        private List<int> _arr = new List<int>();
        public int Length { get; private set; } = 0;
        public void Add(int value)
        {
            _arr.Insert(Length, value);
            Length++;
            var current = Length - 1;
            while(true) {
                var parent = (current-1)/2;
                if (_arr[parent] < _arr[current])
                    Swap(_arr, current, parent);
                if (parent == 0)
                    break;
                current = parent;
            }
        }

        public override string ToString() {
            return "Heap: " + string.Join(", ", _arr.Take(Length))
             + "\nRemoved: " + string.Join(", ", _arr.Skip(Length));
        }

        private static void Swap(List<int> arr, int i, int j){
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public void Remove() {
            if(Length == 0)
                throw new Exception("Heap is empty");
            
            Length--;
            if(Length == 0) {
                return;
            }

            Swap(_arr, 0, Length);
            
            SiftDown(0, _arr, Length);
        }

        private static void SiftDown(int current, List<int> arr, int length) {
            while(true) {
                var left = 2*current+1;
                var right = 2*current+2;
                if (right < length) {
                    if (arr[left] > arr[right]) {
                        if (arr[left] > arr[current]) {
                            Swap(arr, current, left);
                            current = left;
                        } else break;
                    } else {
                        if (arr[right] > arr[current]) {
                            Swap(arr, current, right);
                            current = right;
                        } else break;
                    }
                } else if (left < length) {
                    if (arr[left] > arr[current]) {
                        Swap(arr, current, left);
                        current = left;
                    } else break;
                } else {
                    break;
                }
            }
        }

        public static void Heapify(List<int> arr)
        {
            for (int i = arr.Count-1; i >= 0; i--)
            {
                var parent = (i-1)/2;
                if (parent >= 0 && arr[parent]<arr[i])
                    Swap(arr, parent, i);
                SiftDown(parent, arr, arr.Count);
            }
        }
    }
}