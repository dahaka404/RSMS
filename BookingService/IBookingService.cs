using RSMSMODELS.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BookingService
{
    [ServiceContract]
    public interface IBookingService
    {
        [OperationContract]
        bool CreateBooking(Booking pBooking);

        [OperationContract]
        bool UpdateBooking(Booking pBooking);

        [OperationContract]
        bool CancelBooking(Guid pBookingID);

        [OperationContract]
        Booking GetBooking(Guid pBookingID);

        [OperationContract]
        List<Booking> GetBookingsFromPeriod(DateTime pDateFrom, DateTime ToDate);

        [OperationContract]
        List<Booking> GetBookings();

        [OperationContract]
        Booking GetTableBooking(Guid pBookingID);

        [OperationContract]
        List<Booking> GetTableBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo);

        [OperationContract]
        List<Booking> GetTableBookings();

        [OperationContract]
        bool CreateTableBooking(Guid pBookingID, List<Guid> pTables);

        [OperationContract]
        bool UpdateTableBooking(Guid pBookingID, List<Guid> pOldTables, List<Guid> pNewTables);
    }
}
