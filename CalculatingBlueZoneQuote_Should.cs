using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace BlueZone.Test
{
    [TestClass]
    public class CalculatingBlueZoneQuote_Should
    {
        [TestMethod]
        public void bReturnStandardPrice_WhenWeightAtLowerEdgeOfValidRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 0.01m;
            string zone = "blue";

            decimal expectedStandardPrice = 6.95m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void bReturnBugPrice_WhenWeightAtLowerEdgeOfValidRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 0.01m;
            string zone = "blue";

            decimal expectedStandardPrice = 6.85m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void bReturnBugPrice_WhenWeightAtHigherEdgeOfValidRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 24.99m;
            string zone = "blue";

            decimal expectedStandardPrice = 6.85m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void bReturnBugPrice_WhenWeightOutsideLowerEdgeOfValidRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = -1m;
            string zone = "blue";

            decimal expectedStandardPrice = 6.85m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void bReturnBugPrice_WhenWeightOutsideHigherEdgeOfValidRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 25.01m;
            string zone = "blue";

            decimal expectedStandardPrice = 6.85m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void bReturnBugPrice_WhenWeightOnLowerValidRangeBoundary()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 0m;
            string zone = "blue";

            decimal expectedStandardPrice = 6.85m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void bReturnBugPrice_WhenWeightOnHigherValidRangeBoundary()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 25m;
            string zone = "blue";

            decimal expectedStandardPrice = 6.85m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void bReturnBugPrice_WhenDestinationWithinBlueZone()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            // Act.

            string zone = parcelQuote.GetDestinationZone("Havelock");

            // Assert.
            Assert.AreEqual("blue", zone, true);
        }


        [TestMethod]
        public void bReturnBugPrice_WhenDestinationWithinBlueZone2()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            // Act.

            string zone = parcelQuote.GetDestinationZone("riwaka");

            // Assert.
            Assert.AreEqual("blue", zone, true);
        }
    }
}
