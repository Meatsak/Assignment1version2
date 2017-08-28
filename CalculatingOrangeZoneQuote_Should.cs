using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace OrangeZone.Test
{
    [TestClass]
    public class CalculatingOrangeZoneQuote_Should
    {
        [TestMethod]
        public void oReturnStandardPrice_WhenWeightAtLowerEdgeOfStandardRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 0.01m;
            string zone = "orange";

            decimal expectedStandardPrice = 12.95m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightAtHigherEdgeOfStandardRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 14.99m;
            string zone = "orange";

            decimal expectedStandardPrice = 12.95m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightOutsideHigherEdgeOfStandardRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 15.01m;
            string zone = "orange";

            decimal expectedStandardPrice = 12.95m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightOutsideLowerEdgeOfStandardRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = -1m;
            string zone = "orange";

            decimal expectedStandardPrice = 12.95m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightAtLowerEdgeOfStandardRangeOneTicket()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 15.01m;
            string zone = "orange";

            decimal expectedStandardPrice = 19.15m;
            byte expectedExcessTickets = 1;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightAtHigherEdgeOfStandardRangeOneTicket()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 19.99m;
            string zone = "orange";

            decimal expectedStandardPrice = 19.15m;
            byte expectedExcessTickets = 1;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightAtLowerEdgeOfStandardRangeTwoTicket()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 20.01m;
            string zone = "orange";

            decimal expectedStandardPrice = 25.35m;
            byte expectedExcessTickets = 2;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightAtHigherEdgeOfStandardRangeTwoTicket()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 24.99m;
            string zone = "orange";

            decimal expectedStandardPrice = 25.35m;
            byte expectedExcessTickets = 2;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightOutsideHigherEdgeOfStandardRangeTwoTicket()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 25.01m;
            string zone = "orange";

            decimal expectedStandardPrice = 25.35m;
            byte expectedExcessTickets = 2;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightAtHigherBoundaryOfStandardRangeTwoTicket()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 25.00m;
            string zone = "orange";

            decimal expectedStandardPrice = 25.35m;
            byte expectedExcessTickets = 2;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightAtHigherBoundaryOfStandardRangeOneTicket()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 20.00m;
            string zone = "orange";

            decimal expectedStandardPrice = 19.15m;
            byte expectedExcessTickets = 1;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenWeightAtHigherBoundaryOfStandardRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 15.00m;
            string zone = "orange";

            decimal expectedStandardPrice = 12.95m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void oReturnStandardPrice_WhenDestinationWithinOrangeZone()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            // Act.

            string zone = parcelQuote.GetDestinationZone("hamner springs");

            // Assert.
            Assert.AreEqual("orange", zone, true);
        }
    }
}

