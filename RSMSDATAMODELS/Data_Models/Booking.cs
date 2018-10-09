using System;
using System.Collections.Generic;

namespace RSMSDATAMODELS.Data_Models
{
    public partial class Booking
    {
        public Booking()
        {
            TableBooking = new HashSet<TableBooking>();
        }

        public Guid Id { get; set; }
        public string ContactName { get; set; }
        public DateTime DateTime { get; set; }
        public int PartyNumber { get; set; }
        public bool SpecialOccasion { get; set; }
        public string OtherDetails { get; set; }

        public ICollection<TableBooking> TableBooking { get; set; }
    }
}
