using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var ht = new HashTable<int, string>();
            ht.Add(1,"a");
            ht.Add(2,"b");
            ht.Add(3,"c");
            ht.Add(4,"d");
            ht.Add(5,"e");
            ht.Add(6,"f");
            ht.Add(7,"g");
            ht.Add(8,"h");
            ht.Add(9,"i");
            ht.Add(10,"j");
            ht.Add(11,"k");
            Console.WriteLine(ht);
            Console.WriteLine(ht.Length);

            Console.WriteLine(ht.Get(11));
            
            ht.Remove(11);
            try
            {
                ht.Get(11);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(ht);
            }
            
        }
    }
}
