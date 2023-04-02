using System.Xml.Xsl;

namespace BigRationalLib
{
    public readonly partial struct BigRational : IComparable, IComparable<BigRational>
    {
        public int CompareTo(object? obj)
        {
            if (obj is null) return +1;
            if (obj is not BigRational) throw new ArgumentException();

            var other = (BigRational)obj;
            return this.CompareTo(other);
        }

        public int CompareTo(BigRational other)
        {
            if (IsNaN(this) && !IsNaN(other)) return -1;
            if (!IsNaN(this) && IsNaN(other)) return 1;
            if (IsNaN(this) && IsNaN(other)) return 0;

            if (IsNegativeInfinity(this)) return -1;
            if (IsPositiveInfinity(other)) return 1;

            return (this.Numerator * other.Denominator - this.Denominator * other.Numerator).Sign;
        }

        public static bool operator <(BigRational left, BigRational right) 
            => left.CompareTo(right) < 0;
        public static bool operator >(BigRational left, BigRational right) 
            => left.CompareTo(right) > 0;
        public static bool operator <=(BigRational left, BigRational right) 
            => left.CompareTo(right) <= 0;
        public static bool operator >=(BigRational left, BigRational right) 
            => left.CompareTo(right) >= 0;
    }
}

