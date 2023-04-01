namespace BigRationalLib
{
    public readonly partial struct BigRational : IEquatable<BigRational>
    {
        // implementacja tożsamości instancji
        // ponieważ ułamek zapamiętywany jest w najprostszej, nieskraqcalnej postaci
        // oraz jego postać jest znormalizowan (znak ułamka w liczniku)
        // porównywanie mozna zrealizować jako _pole-po-polu_
        public bool Equals(BigRational other)
        {
            if ((this.Numerator == 0 && this.Denominator == 0)
                || (other.Numerator == 0 && other.Denominator == 0)) return false;

            return (Numerator == other.Numerator && Denominator == other.Denominator);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (obj is not BigRational) return false;

            return Equals((BigRational)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public static bool operator ==(BigRational p1, BigRational p2) => p1.Equals(p2);
        public static bool operator !=(BigRational p1, BigRational p2) => !(p1 == p2);
    }
}

