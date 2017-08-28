using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace LimeZone.Test
{
    [TestClass]
    public class CalculatingLimeZoneQuote_Should
    {
        [TestMethod]
        public void lReturnStandardPrice_WhenWeightAtLowerEdgeOfStandardRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 0.01m;
            string zone = "lime";

            decimal expectedStandardPrice = 8.70m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void lReturnStandardPrice_WhenWeightAtHigherEdgeOfStandardRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 14.99m;
            string zone = "lime";

            decimal expectedStandardPrice = 8.70m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void lReturnStandardPrice_WhenWeightAtLowerBoundaryOfStandardRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 0m;
            string zone = "lime";

            decimal expectedStandardPrice = 8.70m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void lReturnStandardPrice_WhenWeightAtLowerEdgeOfStandardRangeOneTicket()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 15.01m;
            string zone = "lime";

            decimal expectedStandardPrice = 17.40m;
            byte expectedExcessTickets = 1;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void lReturnStandardPrice_WhenWeightOutsideLowerValidRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = -1m;
            string zone = "lime";

            decimal expectedStandardPrice = 8.70m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void lReturnBugPrice_WhenDestinationWithinLimeZone()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            // Act.

            string zone = parcelQuote.GetDestinationZone("Murchison");

            // Assert.
            Assert.AreEqual("lime", zone, true);
        }
    }
}
