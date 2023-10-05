namespace TestKalkulator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodDodawaniaJezeliArgumentyCalkowite()
        {
            int oczekiwana = 10;
            int otrzymana = Kalkulator.dodajDwieLiczby(3, 7);
            Assert.AreEqual(oczekiwana, otrzymana);
        }

        [TestMethod]
        public void TestMetodyDodawanieJezeliArgumentyRzeczywiste()
        {
            double oczekiwana = 3.14;
            double otrzymana = Kalkulator.dodajDwieLiczby(2.1, 1.04);
            Assert.AreEqual(oczekiwana, otrzymana);
        }
        [TestMethod]
        public void TestMetodyDodawaniaBezArgumentu()
        {
            int oczekiwana = 0;
            int otrzymana = Kalkulator.dodajDwieLiczby();
            Assert.AreEqual(oczekiwana, otrzymana);
        }
        [TestMethod]
        public void TestMetodyDodawaniaJezeliJedenArgument()
        {
            int oczekiwana = 5;
            int otrzymana = Kalkulator.dodajDwieLiczby(5);
            Assert.AreEqual(oczekiwana, otrzymana);
        }
        [TestMethod]
        public void TestMetodyDodawaniaJezeliWieleArgumentow()
        {
            int oczekiwana = 20;
            int otrzymana = Kalkulator.dodajDwieLiczby(2,3,5,10);
            Assert.AreEqual(oczekiwana, otrzymana);
        }
    }
}