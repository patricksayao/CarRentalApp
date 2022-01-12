namespace CarRentalApp
{
    partial class ManageRentalRecord
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.buttonEditRecord = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRecordListing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecordListing)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1018, 421);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(157, 55);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.Location = new System.Drawing.Point(1018, 339);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(157, 55);
            this.buttonDeleteRecord.TabIndex = 10;
            this.buttonDeleteRecord.Text = "Delete Record";
            this.buttonDeleteRecord.UseVisualStyleBackColor = true;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // buttonEditRecord
            // 
            this.buttonEditRecord.Location = new System.Drawing.Point(1018, 257);
            this.buttonEditRecord.Name = "buttonEditRecord";
            this.buttonEditRecord.Size = new System.Drawing.Size(157, 55);
            this.buttonEditRecord.TabIndex = 9;
            this.buttonEditRecord.Text = "Edit Record";
            this.buttonEditRecord.UseVisualStyleBackColor = true;
            this.buttonEditRecord.Click += new System.EventHandler(this.buttonEditRecord_Click);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(1018, 172);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(157, 55);
            this.buttonAddRecord.TabIndex = 8;
            this.buttonAddRecord.Text = "Add Record";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wingdings", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 66);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Rental Record";
            // 
            // dataGridViewRecordListing
            // 
            this.dataGridViewRecordListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecordListing.Location = new System.Drawing.Point(54, 172);
            this.dataGridViewRecordListing.Name = "dataGridViewRecordListing";
            this.dataGridViewRecordListing.RowHeadersWidth = 62;
            this.dataGridViewRecordListing.RowTemplate.Height = 28;
            this.dataGridViewRecordListing.Size = new System.Drawing.Size(860, 304);
            this.dataGridViewRecordListing.TabIndex = 6;
            // 
            // ManageRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 520);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDeleteRecord);
            this.Controls.Add(this.buttonEditRecord);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRecordListing);
            this.Name = "ManageRentalRecord";
            this.Text = "Manage Rental Record";
            this.Load += new System.EventHandler(this.ManageRentalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecordListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.Button buttonEditRecord;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRecordListing;
    }
}