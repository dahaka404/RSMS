namespace RSMS
{
    partial class BookingDiary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBookings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBookings
            // 
            this.lblBookings.AutoSize = true;
            this.lblBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookings.Location = new System.Drawing.Point(13, 13);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(214, 26);
            this.lblBookings.TabIndex = 0;
            this.lblBookings.Text = "Restaurant Bookings";
            // 
            // BookingDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 512);
            this.Controls.Add(this.lblBookings);
            this.Name = "BookingDiary";
            this.Text = "BookingDiary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookings;
    }
}