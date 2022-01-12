namespace CarRentalApp
{
    partial class AddEditRentalRecord
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerRented = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturned = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTypeOfCar = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Wingdings", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(13, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 66);
            this.labelTitle.TabIndex = 0;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(23, 171);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(314, 26);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // dateTimePickerRented
            // 
            this.dateTimePickerRented.Location = new System.Drawing.Point(23, 246);
            this.dateTimePickerRented.Name = "dateTimePickerRented";
            this.dateTimePickerRented.Size = new System.Drawing.Size(314, 26);
            this.dateTimePickerRented.TabIndex = 3;
            // 
            // dateTimePickerReturned
            // 
            this.dateTimePickerReturned.Location = new System.Drawing.Point(457, 246);
            this.dateTimePickerReturned.Name = "dateTimePickerReturned";
            this.dateTimePickerReturned.Size = new System.Drawing.Size(312, 26);
            this.dateTimePickerReturned.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Returned";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type Of Car";
            // 
            // comboBoxTypeOfCar
            // 
            this.comboBoxTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfCar.FormattingEnabled = true;
            this.comboBoxTypeOfCar.Location = new System.Drawing.Point(24, 347);
            this.comboBoxTypeOfCar.Name = "comboBoxTypeOfCar";
            this.comboBoxTypeOfCar.Size = new System.Drawing.Size(313, 28);
            this.comboBoxTypeOfCar.TabIndex = 8;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(520, 319);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(192, 90);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date Rented";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(457, 171);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(180, 26);
            this.textBoxCost.TabIndex = 12;
            this.textBoxCost.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cost";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(676, 143);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 20);
            this.labelId.TabIndex = 14;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBoxTypeOfCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerReturned);
            this.Controls.Add(this.dateTimePickerRented);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.AddEditRentalRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerRented;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTypeOfCar;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelId;
    }
}

