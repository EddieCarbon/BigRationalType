

namespace BigRationalLib
{
    public readonly partial struct BigRational
    {
        #region dodawanie
        
        public BigRational Plus(BigRational other)
        {
            if (IsNaN(this) || IsNaN(other)) return NaN;
            if (IsPositiveInfinity(this) || IsPositiveInfinity(other)) return PositiveInfinity;
            if (IsNegativeInfinity(this) || IsNegativeInfinity(other)) return NegativeInfinity;

            return new BigRational(this.Numerator * other.Denominator + this.Denominator * other.Numerator,
                                 this.Denominator * other.Denominator);
        }

        public BigRational Minus(BigRational other)
        {
            if (IsNaN(this) || IsNaN(other)) return NaN;
            if (IsPositiveInfinity(this) || IsPositiveInfinity(other)) return PositiveInfinity;
            if (IsNegativeInfinity(this) || IsNegativeInfinity(other)) return NegativeInfinity;

            return new BigRational(this.Numerator * other.Denominator - this.Denominator * other.Numerator,
                this.Denominator * other.Denominator);
        }

        private static BigRational Sum(BigRational u1, BigRational u2) => u1.Plus(u2);

        public static BigRational Sum(BigRational u1, BigRational u2, params BigRational[]? list)
        {
            if (list is null) return u1.Plus(u2);
            BigRational sum = u1.Plus(u2);

            foreach (var u in list)
                sum = sum.Plus(u);

            return sum;
        }

        private static BigRational Subtract(BigRational u1, BigRational u2) => u1.Minus(u2);

        public static BigRational Subtract(BigRational u1, BigRational u2, params BigRational[]? list)
        {
            if (list is null) return u1.Minus(u2);
            BigRational sub = u1.Minus(u2);

            foreach (var u in list)
            {
                sub = sub.Minus(u);
            }

            return sub;
        }

        public static BigRational operator +(BigRational u1, BigRational u2) => Sum(u1, u2);
        public static BigRational operator ++(BigRational u) => u + One;
        #endregion dodawanie

        #region odejmowanie

        public static BigRational operator --(BigRational u) => u - One;
        public static BigRational operator -(BigRational u) => new (-1 * u.Numerator, u.Denominator);
        public static BigRational operator -(BigRational u1, BigRational u2) => Subtract(u1, u2);
        
        #endregion

        #region mnozenie

        

        #endregion
    }
}

