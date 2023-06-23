using RandomGen;


namespace TestGen
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void EvenNumberTest()
        {
            var randomNumber = Programm.RandomNumbGen();
            Assert.IsTrue(randomNumber % 2 == 0 , $"Number {randomNumber} not even");
        }
    }
}