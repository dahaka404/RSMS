using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RSMSMODELS.Models;
using RSMSSERVICE;

namespace RSMSTESTS.Unit_Tests
{
    [TestClass]
    public class RSMSSERVICETESTS
    {
        [TestMethod]
        public void CreateBookingTest()
        {
            bool lIsCompleted = false;

            BookingService lRSMSSERVICE = new BookingService();

            Booking lBooking = new Booking
            {
                ContactName = "Test",
                BookingDateTime = DateTime.Now,
                PartyNumber = 4,
                SpecialOccasion = true,
                OtherDetails = "N/A"
            };

            lIsCompleted = lRSMSSERVICE.CreateBooking(lBooking);

            Assert.IsTrue(lIsCompleted);
        }

        [TestMethod]
        public void CheckBookingInputNullTest()
        {
            BookingService lRSMSSERVICE = new BookingService();

            Booking lBooking = new Booking
            {
                ContactName = null,
                BookingDateTime = DateTime.Now,
                PartyNumber = 4,
                SpecialOccasion = true,
                OtherDetails = "N/A"
            };

            Assert.ThrowsException<Exception>(() => lRSMSSERVICE.CreateBooking(lBooking));
        }

        [TestMethod]
        public void CheckBookingInputEmptyTest()
        {
            BookingService lRSMSSERVICE = new BookingService();

            Booking lBooking = new Booking
            {
                ContactName = "",
                BookingDateTime = DateTime.Now,
                PartyNumber = 4,
                SpecialOccasion = true,
                OtherDetails = "N/A"
            };

            Assert.ThrowsException<Exception>(() => lRSMSSERVICE.CreateBooking(lBooking));
        }

        [TestMethod]
        public void CheckBookingInputPartyOverMaxTest()
        {
            BookingService lRSMSSERVICE = new BookingService();

            Booking lBooking = new Booking
            {
                ContactName = "Luke",
                BookingDateTime = DateTime.Now,
                PartyNumber = 89,
                SpecialOccasion = true,
                OtherDetails = "N/A"
            };

            Assert.ThrowsException<Exception>(() => lRSMSSERVICE.CreateBooking(lBooking));
        }

        [TestMethod]
        public void CheckBookingInputPartyUnderMinTest()
        {
            BookingService lRSMSSERVICE = new BookingService();

            Booking lBooking = new Booking
            {
                ContactName = "Luke",
                BookingDateTime = DateTime.Now,
                PartyNumber = -20,
                SpecialOccasion = true,
                OtherDetails = "N/A"
            };

            Assert.ThrowsException<Exception>(() => lRSMSSERVICE.CreateBooking(lBooking));
        }



    }
}
