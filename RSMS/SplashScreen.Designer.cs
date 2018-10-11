namespace RSMS
{
    partial class frmSplashScreen
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
            this.grpRSMS = new System.Windows.Forms.GroupBox();
            this.btnBookings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpRSMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRSMS
            // 
            this.grpRSMS.Controls.Add(this.btnBookings);
            this.grpRSMS.Controls.Add(this.button1);
            this.grpRSMS.Location = new System.Drawing.Point(32, 22);
            this.grpRSMS.Name = "grpRSMS";
            this.grpRSMS.Size = new System.Drawing.Size(485, 403);
            this.grpRSMS.TabIndex = 0;
            this.grpRSMS.TabStop = false;
            this.grpRSMS.Text = "RSMS";
            // 
            // btnBookings
            // 
            this.btnBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.Location = new System.Drawing.Point(54, 121);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(379, 47);
            this.btnBookings.TabIndex = 1;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Floor Management";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.grpRSMS);
            this.Name = "frmSplashScreen";
            this.Text = "SplashScreen";
            this.grpRSMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRSMS;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button button1;
    }
}