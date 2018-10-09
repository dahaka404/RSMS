using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSMSMODELS.Models
{
    public class Booking
    {   
        private Guid mBookingID;
        private string mContactName;
        private DateTime mBookingDateTime;
        private int mPartyNumber;
        private bool mSpecialOccasion;
        private string mOtherDetails;

        public Guid BookingID
        {
            get { return mBookingID; }
            set { mBookingID = value; }
        }

        public string ContactName
        {
            get { return mContactName; }
            set { mContactName = value; }
        }

        public DateTime BookingDateTime
        {
            get { return mBookingDateTime; }
            set { mBookingDateTime = value; }
        }

        public int PartyNumber
        {
            get { return mPartyNumber; }
            set { mPartyNumber = value; }
        }

        public bool SpecialOccasion
        {
            get { return mSpecialOccasion; }
            set { mSpecialOccasion = value; }
        }

        public string OtherDetails
        {
            get { return mOtherDetails; }
            set { mOtherDetails = value; }
        }

        public Booking(Guid pBookingID, string pContactName, DateTime pBookingDateTime, int pPartyNumber, bool pSpecialOccasion, string pOtherDetails)
        {
            BookingID = pBookingID;
            ContactName = pContactName;
            BookingDateTime = pBookingDateTime;
            PartyNumber = pPartyNumber;
            SpecialOccasion = pSpecialOccasion;
            OtherDetails = pOtherDetails;
        }
    }
}
