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
        ICollection<TableBooking> GetBookings();
        ICollection<TableBooking> GetBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo);
        TableBooking GetBooking(Guid pBookingID);
        void InsertTableBooking(TableBooking pTableBooking);
        void UpdateTableBooking(TableBooking pTableBooking);
        void DeleteTableBooking(Guid pBookingID);
        void Save();
    }
}
