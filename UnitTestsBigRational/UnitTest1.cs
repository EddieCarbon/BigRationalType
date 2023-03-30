using BigRationalLib;

namespace UnitTestsBigRational
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 3, 1, 3)]
        [DataRow(3, 1, 3, 1)]
        [DataRow(2, 4, 1, 2)]
        [DataRow(0, 2, 0, 1)]
        public void Konstruktor_PoprawneDaneBezUpraszczania_OK(int licznik, int mianownik, int expextedNumerator, int expectedDenominator)
        {
            // arrange - realizowane jako DataRow

            // act
            var u = new BigRational(licznik, mianownik);

            // assert
            Assert.AreEqual(u.Numerator, expextedNumerator);
            Assert.AreEqual(u.Denominator, expectedDenominator);
        }
    }
}