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

        public static BigRational Zero { get; } = new(0);
        public static BigRational One { get; } = new(1);
        public static BigRational Half { get; } = new(1, 2);

        public static BigRational NaN { get; } = default;
        public static BigRational PositiveInfinity { get; } = new(1, 0);
        public static BigRational NegativeInfinity { get; } = new(-1, 0);
        #endregion


        #region ctor's

        public BigRational(BigInteger numerator, BigInteger denominator)
        {
            Numerator = numerator;
            Denominator = denominator;


        }

        public BigRational(BigInteger value) 
            : this(value, 1) 
        {}
        #endregion
    }
}