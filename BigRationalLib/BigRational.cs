using System;
using System.Numerics;

namespace BigRationalLib
{
    public readonly struct BigRational
    {
        public BigInteger Numerator { get; init; }
        public BigInteger Denominator { get; init; }

        public BigRational(BigInteger numerator, BigInteger denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public BigRational(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            string[] array = value.Split('/');
            if (array.Length != 2) throw new FormatException("Invalid fraction format. Expected numerator/denominator.");

            if (BigInteger.TryParse(array[0], out BigInteger x))
            {
                Numerator = x;
            }
            else
            {
                throw new FormatException("Invalid numerator format.");
            }

            if (BigInteger.TryParse(array[1], out BigInteger y))
            {
                Denominator = y;
            }
            else
            {
                throw new FormatException("Invalid denominator format.");
            }
        }


        public static readonly BigRational NaN = new(0, 0);
        public static readonly BigRational Zero = new(0, 1);
        public static readonly BigRational One = new(1, 1);
        public static readonly BigRational Half = new(1, 2);
       

        public override string ToString() => $"{Numerator}/{Denominator}";
    }
}