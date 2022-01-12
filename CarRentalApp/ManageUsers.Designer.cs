namespace CarRentalApp
{
    partial class ManageUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDeactivateActivateUser = new System.Windows.Forms.Button();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wingdings", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manage Users";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(37, 418);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(157, 55);
            this.buttonRefresh.TabIndex = 16;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDeactivateActivateUser
            // 
            this.buttonDeactivateActivateUser.Location = new System.Drawing.Point(37, 330);
            this.buttonDeactivateActivateUser.Name = "buttonDeactivateActivateUser";
            this.buttonDeactivateActivateUser.Size = new System.Drawing.Size(157, 55);
            this.buttonDeactivateActivateUser.TabIndex = 15;
            this.buttonDeactivateActivateUser.Text = "Deactivate / Activate User";
            this.buttonDeactivateActivateUser.UseVisualStyleBackColor = true;
            this.buttonDeactivateActivateUser.Click += new System.EventHandler(this.buttonDeactivateActivateUser_Click);
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Location = new System.Drawing.Point(37, 249);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(157, 55);
            this.buttonResetPassword.TabIndex = 14;
            this.buttonResetPassword.Text = "Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = true;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(37, 169);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(157, 55);
            this.buttonAddNewUser.TabIndex = 13;
            this.buttonAddNewUser.Text = "Add New User";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(259, 169);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 62;
            this.dataGridViewUsers.RowTemplate.Height = 28;
            this.dataGridViewUsers.Size = new System.Drawing.Size(620, 304);
            this.dataGridViewUsers.TabIndex = 12;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 551);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDeactivateActivateUser);
            this.Controls.Add(this.buttonResetPassword);
            this.Controls.Add(this.buttonAddNewUser);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.label1);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDeactivateActivateUser;
        private System.Windows.Forms.Button buttonResetPassword;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
    }
}