using RSMSMODELS.Models;
using System;
using System.Collections.Generic;

namespace BookingService
{
    public class BookingService : IBookingService
    {
        private readonly RSMSSERVICE.BookingService lBookingService;

        public bool CreateBooking(Booking pBooking)
        {
            return lBookingService.CreateBooking(pBooking);
        }

        public bool UpdateBooking(Booking pBooking)
        {
            return lBookingService.UpdateBooking(pBooking);
        }

        public bool CancelBooking(Guid pBookingID)
        {
            return lBookingService.CancelBooking(pBookingID);
        }

        public Booking GetBooking(Guid pBookingID)
        {
            return lBookingService.GetBooking(pBookingID);
        }

        public List<Booking> GetBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo)
        {
            return lBookingService.GetBookingsFromPeriod(pDateFrom, pDateTo);
        }

        public List<Booking> GetBookings()
        {
            return lBookingService.GetBookings();
        }

        public Booking GetTableBooking(Guid pBookingID)
        {
            return lBookingService.GetTableBooking(pBookingID);
        }

        public List<Booking> GetTableBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo)
        {
            return lBookingService.GetTableBookingsFromPeriod(pDateFrom, pDateTo);
        }

        public List<Booking> GetTableBookings()
        {
            return lBookingService.GetTableBookings();
        }

        public bool CreateTableBooking(Guid pBookingID, List<Guid> pTables)
        {
            return lBookingService.CreateTableBooking(pBookingID, pTables);
        }

        public bool UpdateTableBooking(Guid pBookingId, List<Guid> pOldTables, List<Guid> pNewTables)
        {
            return lBookingService.UpdateTableBooking(pBookingId, pOldTables, pNewTables);
        }
    }
}

