using System;
using System.Collections.Generic;

namespace RSMSDATAMODELS.Data_Models
{
    public partial class Table
    {
        public Table()
        {
            TableBooking = new HashSet<TableBooking>();
        }

        public Guid Id { get; set; }
        public int Number { get; set; }
        public int Chairs { get; set; }

        public ICollection<TableBooking> TableBooking { get; set; }
    }
}
