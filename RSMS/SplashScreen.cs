﻿using System;
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
    public partial class frmSplashScreen : Form
    {
        BookingServiceRef.BookingServiceClient lBookingServiceClient;

        public frmSplashScreen(BookingServiceRef.BookingServiceClient pBookingServiceClient)
        {
            InitializeComponent();
            lBookingServiceClient = pBookingServiceClient;
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookingManagement lfrmBookingManagement = new frmBookingManagement(lBookingServiceClient);
            lfrmBookingManagement.ShowDialog();
            this.Close();
        }
    }
}
