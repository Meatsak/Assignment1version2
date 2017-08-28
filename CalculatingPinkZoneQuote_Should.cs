using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace PinkZone.Test
{
    [TestClass]
    public class CalculatingPinkZoneQuote_Should
    {

        [TestMethod]
        public void pReturnStandardPrice_WhenWeightAtLowerEdgeOfValidRange()
            {
                // Arrange.
                ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
                decimal weight = 0.01m;
                string zone = "pink";

                decimal expectedStandardPrice = 4.15m;
                byte expectedExcessTickets = 0;

                // Act.
                ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

                // Assert.
                Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
                Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
            }


        [TestMethod]
        public void pReturnStandardPrice_WhenWeightAtHigherEdgeOfValidRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 24.99m;
            string zone = "pink";

            decimal expectedStandardPrice = 4.15m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }


        [TestMethod]
        public void pReturnStandardPrice_WhenWeightOutsideLowerEdgeOfValidRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = -1m;
            string zone = "pink";

            decimal expectedStandardPrice = 4.15m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }



        [TestMethod]
        public void pReturnStandardPrice_WhenWeightAtLowerValidRange()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            decimal weight = 0m;
            string zone = "pink";

            decimal expectedStandardPrice = 4.15m;
            byte expectedExcessTickets = 0;

            // Act.
            ParcelQuoteResult parcelQuoteResult = parcelQuote.CalculateQuote(weight, zone);

            // Assert.
            Assert.AreEqual(expectedStandardPrice, parcelQuoteResult.Price);
            Assert.AreEqual(expectedExcessTickets, parcelQuoteResult.ExcessTickets);
        }



        [TestMethod]
        public void pReturnStandardPrice_WhenDestinationWithinPinkZone()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            // Act.

            string zone = parcelQuote.GetDestinationZone("Motueka");

            // Assert.
            Assert.AreEqual("Pink", zone, true);
        }


        [TestMethod]
        public void pReturnStandardPrice_WhenDestinationWithinPinkZone2()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            // Act.

            string zone = parcelQuote.GetDestinationZone("blenheim");

            // Assert.
            Assert.AreEqual("pink", zone, true);
        }


        [TestMethod]
        public void pReturnStandardPrice_WhenDestinationWithinBlueZone()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            // Act.

            string zone = parcelQuote.GetDestinationZone("ward");

            // Assert.
            Assert.AreEqual("pink", zone, true);
        }


        [TestMethod]
        public void pReturnStandardPrice_WhenDestinationWithinLimeZone()
        {
            // Arrange.
            ParcelQuoteFromNelson parcelQuote = new ParcelQuoteFromNelson();
            // Act.

            string zone = parcelQuote.GetDestinationZone("murchison");

            // Assert.
            Assert.AreEqual("pink", zone, true);
        }
    }
 }

