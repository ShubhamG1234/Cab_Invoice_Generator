using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalTotalFare()
        {
            //arrange
            CabInvoice cabInvoice = new CabInvoice();

            //act
            int fare = cabInvoice.CalculateFare(10, 30);
            //assert
            Assert.AreEqual(130, fare);

        }

        [TestMethod]
        public void CheckMinimumFairAsFive()
        {
            //arrange
            CabInvoice cabInvoice = new CabInvoice();

            double fare = cabInvoice.CalculateFare(0, 0);
            Assert.AreEqual(5, fare);
        }

        [TestMethod]
        public void CalAggFairAndMultipleRide()
        {
            CabInvoice cabInvoice = new CabInvoice();
            cabInvoice.AddRide(2, 5);
            cabInvoice.AddRide(12, 15);
            double fare = cabInvoice.CalculateAggregate();
            Assert.AreEqual(160, fare);
        }
    }
}