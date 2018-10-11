namespace RSMS
{
    partial class frmBookingManagement
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBookingDateTime = new System.Windows.Forms.Label();
            this.dtpBookingDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblPartyNumber = new System.Windows.Forms.Label();
            this.numPartyNumber = new System.Windows.Forms.NumericUpDown();
            this.grpSpecialOccasion = new System.Windows.Forms.GroupBox();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rtxtOtherDetails = new System.Windows.Forms.RichTextBox();
            this.lblOtherDetails = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartyNumber)).BeginInit();
            this.grpSpecialOccasion.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Booking Management";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(137, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblBookingDateTime
            // 
            this.lblBookingDateTime.AutoSize = true;
            this.lblBookingDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDateTime.Location = new System.Drawing.Point(17, 107);
            this.lblBookingDateTime.Name = "lblBookingDateTime";
            this.lblBookingDateTime.Size = new System.Drawing.Size(113, 20);
            this.lblBookingDateTime.TabIndex = 3;
            this.lblBookingDateTime.Text = "Date and Time";
            // 
            // dtpBookingDateTime
            // 
            this.dtpBookingDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDateTime.Location = new System.Drawing.Point(137, 102);
            this.dtpBookingDateTime.Name = "dtpBookingDateTime";
            this.dtpBookingDateTime.Size = new System.Drawing.Size(312, 26);
            this.dtpBookingDateTime.TabIndex = 4;
            // 
            // lblPartyNumber
            // 
            this.lblPartyNumber.AutoSize = true;
            this.lblPartyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyNumber.Location = new System.Drawing.Point(17, 154);
            this.lblPartyNumber.Name = "lblPartyNumber";
            this.lblPartyNumber.Size = new System.Drawing.Size(105, 20);
            this.lblPartyNumber.TabIndex = 5;
            this.lblPartyNumber.Text = "Party Number";
            // 
            // numPartyNumber
            // 
            this.numPartyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPartyNumber.Location = new System.Drawing.Point(137, 152);
            this.numPartyNumber.Name = "numPartyNumber";
            this.numPartyNumber.Size = new System.Drawing.Size(312, 26);
            this.numPartyNumber.TabIndex = 6;
            // 
            // grpSpecialOccasion
            // 
            this.grpSpecialOccasion.Controls.Add(this.rbtnNo);
            this.grpSpecialOccasion.Controls.Add(this.rbtnYes);
            this.grpSpecialOccasion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSpecialOccasion.Location = new System.Drawing.Point(12, 197);
            this.grpSpecialOccasion.Name = "grpSpecialOccasion";
            this.grpSpecialOccasion.Size = new System.Drawing.Size(437, 52);
            this.grpSpecialOccasion.TabIndex = 7;
            this.grpSpecialOccasion.TabStop = false;
            this.grpSpecialOccasion.Text = "Special Occasion";
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(196, 22);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(55, 24);
            this.rbtnYes.TabIndex = 0;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(296, 22);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(47, 24);
            this.rbtnNo.TabIndex = 1;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rtxtOtherDetails
            // 
            this.rtxtOtherDetails.Location = new System.Drawing.Point(13, 292);
            this.rtxtOtherDetails.Name = "rtxtOtherDetails";
            this.rtxtOtherDetails.Size = new System.Drawing.Size(436, 99);
            this.rtxtOtherDetails.TabIndex = 8;
            this.rtxtOtherDetails.Text = "";
            // 
            // lblOtherDetails
            // 
            this.lblOtherDetails.AutoSize = true;
            this.lblOtherDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherDetails.Location = new System.Drawing.Point(20, 269);
            this.lblOtherDetails.Name = "lblOtherDetails";
            this.lblOtherDetails.Size = new System.Drawing.Size(102, 20);
            this.lblOtherDetails.TabIndex = 9;
            this.lblOtherDetails.Text = "Other Details";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(107, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(366, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Booking";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(-1, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmBookingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 440);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOtherDetails);
            this.Controls.Add(this.rtxtOtherDetails);
            this.Controls.Add(this.grpSpecialOccasion);
            this.Controls.Add(this.numPartyNumber);
            this.Controls.Add(this.lblPartyNumber);
            this.Controls.Add(this.dtpBookingDateTime);
            this.Controls.Add(this.lblBookingDateTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmBookingManagement";
            this.Text = "Booking Management";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPartyNumber)).EndInit();
            this.grpSpecialOccasion.ResumeLayout(false);
            this.grpSpecialOccasion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOtherDetails;
        private System.Windows.Forms.RichTextBox rtxtOtherDetails;
        private System.Windows.Forms.GroupBox grpSpecialOccasion;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.NumericUpDown numPartyNumber;
        private System.Windows.Forms.Label lblPartyNumber;
        private System.Windows.Forms.DateTimePicker dtpBookingDateTime;
        private System.Windows.Forms.Label lblBookingDateTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
    }
}

