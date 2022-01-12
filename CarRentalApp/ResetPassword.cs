using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntities _db;
        private Utils _utils;
        private User _user;
        public ResetPassword(User user)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            _utils = new Utils();
            _user = user;
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var new_password = textBoxEnterNewPassword.Text;
                var confirmed_password = textBoxConfirmNewPassword.Text;
                var userId = _db.Users.FirstOrDefault(select => select.Id == _user.Id);

                if (new_password != confirmed_password)
                {
                    MessageBox.Show("Password does not match. Try again.");
                }

                userId.password = Utils.HashPassword(new_password);
                _db.SaveChanges();
                MessageBox.Show("New password has been saved");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
