using System;

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
}
