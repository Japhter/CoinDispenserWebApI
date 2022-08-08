using CoinDispenserWebApI.CoinDispenserService;
using NUnit.Framework;

namespace CoinDispenserUnitTests
{
    public class CoinDispenserServiceTests
    {
        CoinDispenserService dispenserService;
        [SetUp]
        public void Setup()
        {
            dispenserService = new CoinDispenserService();
        }
        [Test]
       
        public void CoinDispenserTest1()
        {
            //Minimum coins to make 7 from {1, 2, 3} is 3 this test should pass
            int[] arrayTest = new int[] { 1, 2, 3};
            
            var minCombination = dispenserService.MinCombination(arrayTest, 3);

            Assert.That(minCombination,Is.EqualTo(3));
        }
        [Test]
        public void CoinDispenserTest2()
        {
            //Minimum combination to make 2 from {1, 2, 3,5,7} is 1 this test should pass
            int[] arrayTest = new int[] { 1, 2, 3, 5, 7 };
       
            var minCombination = dispenserService.MinCombination(arrayTest, 2);

            Assert.That(minCombination, Is.EqualTo(1));
        }

        [Test]
        public void CoinDispenserTest3()
        {
            //If amount is 0 ,  0 minimum combination this test should pass
            int[] arrayTest = new int[] { 1, 2, 3, 5, 7 };
           
            var minCombination = dispenserService.MinCombination(arrayTest, 0);

            Assert.That(minCombination, Is.EqualTo(0));

        }
    }
}