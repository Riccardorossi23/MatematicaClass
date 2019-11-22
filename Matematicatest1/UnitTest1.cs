using MatematicaClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matematicatest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
           public static void TestSomma()
           {
                double num1 = 4;
                double num2 = 4;
                double somma_aspettata = 8;
                double somma = Operazioni.Somma(num1, num2);
                Assert.AreEqual(somma_aspettata, somma);
           }
        [TestMethod]
        public static void Test_Sottrazione()
        {
            double num1 = 5;
            double num2 = 3;
            double differenza_aspettata = 2;
            double differenza = Operazioni.Sottrazione(num1, num2);
            Assert.AreEqual(differenza_aspettata, differenza);
        }
        [TestMethod]
        public static void Test_Divisione()
        {
            double num1 = 6;
            double num2 = 4;
            double divisione_aspettata = 1.5;
            double divisione = Operazioni.Divisione(num1, num2);
            Assert.AreEqual(divisione_aspettata, divisione);
        }
        [TestMethod]
        public static void Test_Moltplicazione()
        {
            double num1 = 3;
            double num2 = 4;
            double prodotto_aspettata = 12;
            double prodotto = Operazioni.Moltiplicazione(num1, num2);
            Assert.AreEqual(prodotto_aspettata, prodotto);
        }
    }
}





