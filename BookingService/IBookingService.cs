using RSMSMODELS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBookingService
    {
        [OperationContract]
        bool CreateBooking(Booking pBooking, List<Guid> pTables);

        [OperationContract]
        bool UpdateBooking(Booking pBooking, List<Guid> pTables);

        [OperationContract]
        bool CancelBooking(Guid pBookingID);

        [OperationContract]
        TableBooking GetBooking(Guid pBookingID);

        [OperationContract]
        List<TableBooking> GetBookingsFromPeriod(DateTime pDateFrom, DateTime ToDate);

        [OperationContract]
        List<TableBooking> GetBookings();
    }
}
