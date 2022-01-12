namespace CarRentalApp
{
    partial class ManageVehicleListing
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
            this.dataGridViewVehicleListing = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonEditCar = new System.Windows.Forms.Button();
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicleListing)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVehicleListing
            // 
            this.dataGridViewVehicleListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicleListing.Location = new System.Drawing.Point(46, 115);
            this.dataGridViewVehicleListing.Name = "dataGridViewVehicleListing";
            this.dataGridViewVehicleListing.RowHeadersWidth = 62;
            this.dataGridViewVehicleListing.RowTemplate.Height = 28;
            this.dataGridViewVehicleListing.Size = new System.Drawing.Size(999, 304);
            this.dataGridViewVehicleListing.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wingdings", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Vehicle Listing";
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(1068, 115);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(157, 55);
            this.buttonAddCar.TabIndex = 2;
            this.buttonAddCar.Text = "Add Car";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonEditCar
            // 
            this.buttonEditCar.Location = new System.Drawing.Point(1068, 195);
            this.buttonEditCar.Name = "buttonEditCar";
            this.buttonEditCar.Size = new System.Drawing.Size(157, 55);
            this.buttonEditCar.TabIndex = 3;
            this.buttonEditCar.Text = "Edit Car";
            this.buttonEditCar.UseVisualStyleBackColor = true;
            this.buttonEditCar.Click += new System.EventHandler(this.buttonEditCar_Click);
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.Location = new System.Drawing.Point(1068, 279);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(157, 55);
            this.buttonDeleteCar.TabIndex = 4;
            this.buttonDeleteCar.Text = "Delete Car";
            this.buttonDeleteCar.UseVisualStyleBackColor = true;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1068, 364);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(157, 55);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 450);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDeleteCar);
            this.Controls.Add(this.buttonEditCar);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVehicleListing);
            this.Name = "ManageVehicleListing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicleListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehicleListing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonEditCar;
        private System.Windows.Forms.Button buttonDeleteCar;
        private System.Windows.Forms.Button buttonRefresh;
    }
}