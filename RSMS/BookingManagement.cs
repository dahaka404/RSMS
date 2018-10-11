using RSMSMODELS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSMS
{
    public partial class frmBookingManagement : Form
    {
        BookingServiceRef.BookingServiceClient lBookingServiceClient;
        bool IsCompleted = false;

        public frmBookingManagement(BookingServiceRef.BookingServiceClient pBookingServiceClient)
        {
            InitializeComponent();
            lBookingServiceClient = pBookingServiceClient;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BookingServiceRef.Booking lBooking = new BookingServiceRef.Booking();
            lBooking.ContactName = this.txtName.Text.ToString();
            lBooking.BookingDateTime = Convert.ToDateTime(this.dtpBookingDateTime.Text);
            lBooking.PartyNumber = Convert.ToInt32(this.numPartyNumber.Value);
            lBooking.SpecialOccasion = rbtnYes.Checked ? true : rbtnNo.Checked ? false : false;
            lBooking.OtherDetails = this.rtxtOtherDetails.Text.ToString();

           IsCompleted = lBookingServiceClient.CreateBooking(lBooking);
        }
    }
}
