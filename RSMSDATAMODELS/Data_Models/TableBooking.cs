using System;
using System.Collections.Generic;

namespace RSMSDATAMODELS.Data_Models
{
    public partial class TableBooking
    {
        public Guid BookingId { get; set; }
        public Guid TableId { get; set; }

        public Booking Booking { get; set; }
        public Table Table { get; set; }
    }
}
