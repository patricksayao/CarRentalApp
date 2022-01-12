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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        public void PopulateGrid()
        {
            // the data that will be shown
            var users = _db.Users
                .Select(select => new
                {
                    select.Id,
                    Username = select.username,
                    Role = select.UserRoles.FirstOrDefault().Role.Name,
                    Active = select.isActive
                })
                .ToList();

            // where the datagrid gets the data from
            dataGridViewUsers.DataSource = users;
            // makes the column with name Id, invisible
            dataGridViewUsers.Columns["Id"].Visible = false;
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }            
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dataGridViewUsers.SelectedRows[0].Cells["Id"].Value;
                var user = _db.Users.FirstOrDefault(select => select.Id == id);

                DialogResult dialogresult = MessageBox.Show("Are you sure you want to reset the password for this user?",
                    "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Yes)
                {
                    //var default_password = "password@123";
                    //var hashed_password = Utils.HashPassword(default_password);
                    user.password = Utils.DefaultHashedPassword(); // came from utils
                    _db.SaveChanges();
                    MessageBox.Show($"{user.username}'s Password is reset");
                }
                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a user to edit the password");
                //throw;
            }
        }

        private void buttonDeactivateActivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dataGridViewUsers.SelectedRows[0].Cells["Id"].Value;

                var user = _db.Users.FirstOrDefault(select => select.Id == id);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to change the active status of this record?",
                    "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //if (user.isActive == true)
                    //{
                    //    user.isActive = false;
                    //}
                    //else
                    //{
                    //    user.isActive = true;
                    //}
                    // combined the code into a single line using shorthand
                    user.isActive = user.isActive == true ? false : true;
                    _db.SaveChanges();

                    MessageBox.Show($"{user.username}'s active status has changed");
                }
                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a user to deactivate/activate");
                //throw;
            }            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
