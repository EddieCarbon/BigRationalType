using System;
using BigRationalLib;

namespace BigRationalType
{
    class Program
    {
        static void Main(string[] args) 
        {
            var u = new BigRational(2,4);
            var s = u.ToString();
            Console.WriteLine(s);
        }
    }
}
