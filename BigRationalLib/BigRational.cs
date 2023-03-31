using System;
using System.Numerics;

namespace BigRationalLib
{
    public readonly partial struct BigRational
    {
        public BigInteger Numerator { get; init; } = 0;
        public BigInteger Denominator { get; init; } = 1;


        #region constants

        private static readonly string POSITIVE_INFINITY = "+Infinity";
        private static readonly string NEGATIVE_INFINITY = "Infinity";
        private static readonly string NAN = "NaN";

        public static BigRational Zero { get; } = new(0); // 0/1
        public static BigRational One { get; } = new(1); // 1/1
        public static BigRational Half { get; } = new(1, 2); // 1/2

        public static BigRational NaN { get; } = default; // 0/0
        public static BigRational PositiveInfinity { get; } = new(1, 0); // a/0, a > 0
        public static BigRational NegativeInfinity { get; } = new(-1, 0); // a/0, a < 0
        #endregion


        #region ctor's

        public BigRational(BigInteger numerator, BigInteger denominator)
        {
            Numerator = numerator;
            Denominator = denominator;

            // sign standarization
            if (Numerator < 0 && Denominator < 0)
                (Numerator, Denominator) = ((-1) * Numerator, (-1) * Denominator);

            if (Numerator > 0 && Denominator < 0)
                (Numerator, Denominator) = ((-1) * Numerator, (-1) * Denominator);
            
            // special cases
            if (Numerator == 0 && Denominator == 0) // Bigrational.NaN
                return;

            if (Numerator > 0 && Denominator == 0) // BigRational.PositiveInfinity
            {
                (Numerator, Denominator) = (1, 0);
                return;
            }

            if (Numerator < 0 && Denominator == 0) // BigRational.NegativeInfinity
            {
                (Numerator, Denominator) = (-1, 0);
                return;
            }
        }

        public BigRational(BigInteger value)
            : this(value, 1)
        { }
        
        public BigRational()
            : this( 0, 1 ) 
        {}

        #endregion
    }
}