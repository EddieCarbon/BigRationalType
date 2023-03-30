using System;
using BigRationalLib;

namespace BigRationalType
{
    class Program
    {
        static void Main(string[] args) 
        {
            var u = new BigRational(0, 0);
            Console.WriteLine(u);
            var s = u.ToString();
            Console.WriteLine(s);
            var v = new BigRational(s);
            Console.WriteLine(v);
            // u oraz v są "takie same"
        }
    }
}
