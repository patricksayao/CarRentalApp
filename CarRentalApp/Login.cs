using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities _db;
        private Utils _utils; // Utils is where the hashing of password happen
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            _utils = new Utils();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = textBoxUsername.Text.Trim();
                var password = textBoxPassword.Text;

                var hashed_password = Utils.HashPassword(password); // uses a method from Utils to hash the password
                

                var user = _db.Users.FirstOrDefault(select => select.username == username && 
                    select.password == hashed_password && select.isActive == true);

                if (user == null)
                {
                    MessageBox.Show("Please enter valid login information");
                }
                else
                {                    
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
