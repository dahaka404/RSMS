using RSMSMODELS.Models;
using System;
using System.Collections.Generic;

namespace BookingService
{
    public class BookingService : IBookingService
    {
        private readonly RSMSSERVICE.BookingService lBookingService;

        public bool CreateBooking(Booking pBooking, List<Guid> pTables)
        {
            return lBookingService.CreateBooking(pBooking, pTables);
        }

        public bool UpdateBooking(Booking pBooking, List<Guid> pTables)
        {
            return lBookingService.UpdateBooking(pBooking, pTables);
        }

        public bool CancelBooking(Guid pBookingID)
        {
            return lBookingService.CancelBooking(pBookingID);
        }

        public TableBooking GetBooking(Guid pBookingID)
        {
            return lBookingService.GetBooking(pBookingID);
        }

        public List<TableBooking> GetBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo)
        {
            return lBookingService.GetBookingsFromPeriod(pDateFrom, pDateTo);
        }

        public List<TableBooking> GetBookings()
        {
            return lBookingService.GetBookings();
        }
    }
}

