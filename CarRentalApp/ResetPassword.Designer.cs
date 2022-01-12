namespace CarRentalApp
{
    partial class ResetPassword
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
            this.textBoxEnterNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Password";
            // 
            // textBoxEnterNewPassword
            // 
            this.textBoxEnterNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterNewPassword.Location = new System.Drawing.Point(181, 106);
            this.textBoxEnterNewPassword.Name = "textBoxEnterNewPassword";
            this.textBoxEnterNewPassword.PasswordChar = ' ';
            this.textBoxEnterNewPassword.Size = new System.Drawing.Size(414, 44);
            this.textBoxEnterNewPassword.TabIndex = 1;
            // 
            // textBoxConfirmNewPassword
            // 
            this.textBoxConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmNewPassword.Location = new System.Drawing.Point(181, 282);
            this.textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            this.textBoxConfirmNewPassword.PasswordChar = ' ';
            this.textBoxConfirmNewPassword.Size = new System.Drawing.Size(414, 44);
            this.textBoxConfirmNewPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirm New Password";
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetPassword.Location = new System.Drawing.Point(262, 397);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(237, 66);
            this.buttonResetPassword.TabIndex = 4;
            this.buttonResetPassword.Text = "Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = true;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.buttonResetPassword);
            this.Controls.Add(this.textBoxConfirmNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEnterNewPassword);
            this.Controls.Add(this.label1);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnterNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonResetPassword;
    }
}