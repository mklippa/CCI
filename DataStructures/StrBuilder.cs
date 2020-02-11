using System.Linq;

namespace practice
{
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
