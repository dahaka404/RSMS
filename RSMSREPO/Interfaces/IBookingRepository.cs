using RSMSDATAMODELS.Data_Models;
using System;
using System.Collections.Generic;

namespace RSMSREPO.Interfaces
{
    public interface IBookingRepository : IDisposable
    {
        void InsertBooking(Booking pBooking);
        void UpdateBooking(Booking pBooking);
        void DeleteBooking(Guid pBookingID);
        ICollection<Booking> GetBookings();
        ICollection<Booking> GetBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo);
        Booking GetBooking(Guid pBookingID);
        void InsertTableBooking(TableBooking pTableBooking);
        void UpdateTableBooking(TableBooking pTableBooking);
        void DeleteTableBooking(Guid pBookingID);
        ICollection<Booking> GetTableBookings();
        ICollection<Booking> GetTableBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo);
        Booking GetTableBooking(Guid pBookingID);
        void Save();
    }
}
