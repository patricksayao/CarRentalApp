namespace CarRentalApp
{
    partial class AddEditVehicle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxVin = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxLicensePlateNumber = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxLicensePlateNumber, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMake, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 152);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 392);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(113, 581);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(263, 63);
            this.buttonSaveChanges.TabIndex = 1;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(591, 581);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(263, 63);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Wingdings", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(199, 41);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 66);
            this.labelTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "VIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "License Plate Number";
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(444, 3);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(284, 26);
            this.textBoxMake.TabIndex = 9;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(444, 81);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(284, 26);
            this.textBoxModel.TabIndex = 10;
            // 
            // textBoxVin
            // 
            this.textBoxVin.Location = new System.Drawing.Point(444, 159);
            this.textBoxVin.Name = "textBoxVin";
            this.textBoxVin.Size = new System.Drawing.Size(284, 26);
            this.textBoxVin.TabIndex = 11;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(444, 237);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(284, 26);
            this.textBoxYear.TabIndex = 12;
            // 
            // textBoxLicensePlateNumber
            // 
            this.textBoxLicensePlateNumber.Location = new System.Drawing.Point(444, 315);
            this.textBoxLicensePlateNumber.Name = "textBoxLicensePlateNumber";
            this.textBoxLicensePlateNumber.Size = new System.Drawing.Size(284, 26);
            this.textBoxLicensePlateNumber.TabIndex = 13;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(528, 113);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 20);
            this.labelId.TabIndex = 4;
            this.labelId.Visible = false;
            // 
            // AddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 671);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVehicle";
            this.Text = "AddEditVehicle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxLicensePlateNumber;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxVin;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelId;
    }
}