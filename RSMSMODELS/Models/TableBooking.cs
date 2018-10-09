using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSMSMODELS.Models
{
    public class TableBooking
    {
        private Guid mBookingID;
        private Guid mTableID;

        public Guid BookingID
        {
            get { return mBookingID; }
            set { mBookingID = value; }
        }

        public Guid TableID
        {
            get { return mTableID; }
            set { mTableID = value; }
        }

        public TableBooking()
        {

        }

        public TableBooking(Guid pBookingID, Guid pTableID)
        {
            this.BookingID = pBookingID;
            this.TableID = pTableID;
        }
    }
}
