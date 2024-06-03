namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // IbCarID
            // 
            this.IbCarID.AutoSize = true;
            this.IbCarID.Location = new System.Drawing.Point(24, 28);
            this.IbCarID.Name = "IbCarID";
            this.IbCarID.Size = new System.Drawing.Size(55, 20);
            this.IbCarID.TabIndex = 0;
            this.IbCarID.Text = "Car ID";
            // 
            // IbCarName
            // 
            this.IbCarName.AutoSize = true;
            this.IbCarName.Location = new System.Drawing.Point(24, 71);
            this.IbCarName.Name = "IbCarName";
            this.IbCarName.Size = new System.Drawing.Size(80, 20);
            this.IbCarName.TabIndex = 1;
            this.IbCarName.Text = "Car Name";
            // 
            // IbManufacturer
            // 
            this.IbManufacturer.AutoSize = true;
            this.IbManufacturer.Location = new System.Drawing.Point(24, 117);
            this.IbManufacturer.Name = "IbManufacturer";
            this.IbManufacturer.Size = new System.Drawing.Size(104, 20);
            this.IbManufacturer.TabIndex = 2;
            this.IbManufacturer.Text = "Manufacturer";
            // 
            // IbPrice
            // 
            this.IbPrice.AutoSize = true;
            this.IbPrice.Location = new System.Drawing.Point(382, 28);
            this.IbPrice.Name = "IbPrice";
            this.IbPrice.Size = new System.Drawing.Size(44, 20);
            this.IbPrice.TabIndex = 3;
            this.IbPrice.Text = "Price";
            // 
            // IbReleaseYear
            // 
            this.IbReleaseYear.AutoSize = true;
            this.IbReleaseYear.Location = new System.Drawing.Point(382, 70);
            this.IbReleaseYear.Name = "IbReleaseYear";
            this.IbReleaseYear.Size = new System.Drawing.Size(102, 20);
            this.IbReleaseYear.TabIndex = 4;
            this.IbReleaseYear.Text = "ReleaseYear";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(125, 21);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(203, 26);
            this.txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(125, 64);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(203, 26);
            this.txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(125, 110);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(203, 26);
            this.txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(490, 21);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(229, 26);
            this.txtPrice.TabIndex = 8;
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(490, 67);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(229, 26);
            this.txtReleaseYear.TabIndex = 9;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(149, 165);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 35);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(386, 165);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(632, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvCarList
            // 
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Location = new System.Drawing.Point(12, 206);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.ReadOnly = true;
            this.dgvCarList.RowHeadersWidth = 62;
            this.dgvCarList.RowTemplate.Height = 28;
            this.dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarList.Size = new System.Drawing.Size(776, 196);
            this.dgvCarList.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(386, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmCarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvCarList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.IbReleaseYear);
            this.Controls.Add(this.IbPrice);
            this.Controls.Add(this.IbManufacturer);
            this.Controls.Add(this.IbCarName);
            this.Controls.Add(this.IbCarID);
            this.Name = "frmCarManagement";
            this.Text = "frmCarManagement";
            this.Load += new System.EventHandler(this.frmCarManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
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
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btnClose;
    }
}