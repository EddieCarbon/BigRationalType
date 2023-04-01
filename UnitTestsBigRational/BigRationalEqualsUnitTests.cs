using BigRationalLib;

namespace UnitTestsBigRational
{
    [TestClass]
    public class BigRationalEqualsUnitTests
    {
        [DataTestMethod]
        [DataRow(1, 2, 1, 2, 1, 2)]
        [DataRow(1, 2, 2, 4, 3, 6)]
        [DataRow(-1, 2, 2, -4, -3, 6)]
        [DataRow(1, 2, -1, 2, 1, 2)]
        [DataRow(1, 2, 1, 3, 1, 3)]
        [DataRow(1, 2, 1, 2, 1, 3)]
        public void Equals_Przechodniosc_ZPrawLogiki_DowolneDane(int u1l, int u1m, int u2l, int u2m, int u3l, int u3m)
        {
            BigRational x = new (u1l, u1m);
            BigRational y = new (u2l, u2m);
            BigRational z = new (u3l, u3m);

            Assert.IsTrue( !x.Equals(y) || !y.Equals(z) || x.Equals(z) );
        }

    }
}

