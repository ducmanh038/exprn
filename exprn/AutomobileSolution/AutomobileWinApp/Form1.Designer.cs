namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            this.IbCarID = new System.Windows.Forms.Label();
            this.IbCarName = new System.Windows.Forms.Label();
            this.IbManufacturer = new System.Windows.Forms.Label();
            this.IbPrice = new System.Windows.Forms.Label();
            this.IbReleaseYear = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            this.cboManufacturer = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IbCarID
            // 
            this.IbCarID.AutoSize = true;
            this.IbCarID.Location = new System.Drawing.Point(56, 45);
            this.IbCarID.Name = "IbCarID";
            this.IbCarID.Size = new System.Drawing.Size(55, 20);
            this.IbCarID.TabIndex = 0;
            this.IbCarID.Text = "Car ID";
            // 
            // IbCarName
            // 
            this.IbCarName.AutoSize = true;
            this.IbCarName.Location = new System.Drawing.Point(56, 86);
            this.IbCarName.Name = "IbCarName";
            this.IbCarName.Size = new System.Drawing.Size(80, 20);
            this.IbCarName.TabIndex = 1;
            this.IbCarName.Text = "Car Name";
            // 
            // IbManufacturer
            // 
            this.IbManufacturer.AutoSize = true;
            this.IbManufacturer.Location = new System.Drawing.Point(56, 122);
            this.IbManufacturer.Name = "IbManufacturer";
            this.IbManufacturer.Size = new System.Drawing.Size(104, 20);
            this.IbManufacturer.TabIndex = 2;
            this.IbManufacturer.Text = "Manufacturer";
            // 
            // IbPrice
            // 
            this.IbPrice.AutoSize = true;
            this.IbPrice.Location = new System.Drawing.Point(56, 159);
            this.IbPrice.Name = "IbPrice";
            this.IbPrice.Size = new System.Drawing.Size(44, 20);
            this.IbPrice.TabIndex = 3;
            this.IbPrice.Text = "Price";
            // 
            // IbReleaseYear
            // 
            this.IbReleaseYear.AutoSize = true;
            this.IbReleaseYear.Location = new System.Drawing.Point(56, 197);
            this.IbReleaseYear.Name = "IbReleaseYear";
            this.IbReleaseYear.Size = new System.Drawing.Size(102, 20);
            this.IbReleaseYear.TabIndex = 4;
            this.IbReleaseYear.Text = "ReleaseYear";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(190, 38);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(210, 26);
            this.txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(190, 79);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(210, 26);
            this.txtCarName.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(190, 152);
            this.txtPrice.Mask = "000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 26);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(190, 190);
            this.txtReleaseYear.Mask = "0000";
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(210, 26);
            this.txtReleaseYear.TabIndex = 8;
            this.txtReleaseYear.Text = "0";
            // 
            // cboManufacturer
            // 
            this.cboManufacturer.FormattingEnabled = true;
            this.cboManufacturer.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Ford",
            "Honda",
            "Hyundai",
            "Kia",
            "Suzuki",
            "Toyota"});
            this.cboManufacturer.Location = new System.Drawing.Point(190, 113);
            this.cboManufacturer.Name = "cboManufacturer";
            this.cboManufacturer.Size = new System.Drawing.Size(210, 28);
            this.cboManufacturer.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(190, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(324, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboManufacturer);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.IbReleaseYear);
            this.Controls.Add(this.IbPrice);
            this.Controls.Add(this.IbManufacturer);
            this.Controls.Add(this.IbCarName);
            this.Controls.Add(this.IbCarID);
            this.Name = "frmCarDetails";
            this.Text = "frmCarDetails";
            this.Load += new System.EventHandler(this.frmCarDetails_Load);
            this.Click += new System.EventHandler(this.frmCarDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbCarID;
        private System.Windows.Forms.Label IbCarName;
        private System.Windows.Forms.Label IbManufacturer;
        private System.Windows.Forms.Label IbPrice;
        private System.Windows.Forms.Label IbReleaseYear;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

