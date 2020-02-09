using System;
using System.Linq;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StrBuilder();
            builder.Append("abc");
            builder.Append("de");
            builder.Append("fghijkl");
            var str =  builder.ToString();
            Console.WriteLine(str);
        }
    }

    public class StrBuilder
    {        
        private char[] _arr = new char[1];
        private int _len = 0;

        public void Append(string str)
        {
            while (_len + str.Length > _arr.Length)
            {
                Increase();
            }

            foreach (var ch in str)
            {
                _arr[_len] = ch;
                _len++;
            }
        }

        public override string ToString()
        {
            return new string(_arr.Take(_len).ToArray());
        }

        private void Increase()
        {
            var new_arr = new char[_arr.Length * 2];
            for (int i = 0; i < _len; i++)
            {
                new_arr[i] = _arr[i];
            }
            _arr = new_arr;
        }
    }
}
