using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Gonzalo", "2.686.797-9", "8-1999-10");
            string expected = "Gonzalo";
            Assert.AreEqual(expected, p.Name);
        }

        [Test]
        public void TestID() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Gonzalo", "2.686.797-7", "8-1999-10");
            string expected = null;
            Assert.AreEqual(expected, p.ID);
        }

        [Test]
        public void TestFecha() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Gonzalo", "2.686.797-7", "8-1999-10");
            string expected = "8-1999-10";
            Assert.AreEqual(expected, p.Fecha);
        }

        







    }
}