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
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities _db;
        private Utils _utils;
        private ManageUsers _manageUsers;

        //public AddUser()
        //{
        //    InitializeComponent();
        //    _db = new CarRentalEntities();
        //    _utils = new Utils();
        //}
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            _utils = new Utils();
            _manageUsers = manageUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var role = _db.Roles        // can just be _db.Roles.ToList();
                .Select(select => new
                {
                    select.Id,
                    select.Name
                })
                .ToList();

            comboBoxRole.DisplayMember = "Name";
            comboBoxRole.ValueMember = "Id";
            comboBoxRole.DataSource = role;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var username = textBoxUsername.Text.Trim();
                var password = Utils.DefaultHashedPassword(); // came from utils class
                var roleId = (int)comboBoxRole.SelectedValue;

                var user = new User
                {
                    username = username,
                    password = password,
                    isActive = true
                };

                _db.Users.Add(user);
                _db.SaveChanges();

                var userId = user.Id;

                var userRole = new UserRole
                {
                    Userid = userId,
                    Roleid = roleId
                };

                _db.UserRoles.Add(userRole);
                _db.SaveChanges();

                MessageBox.Show("New user added succesfully");
                _manageUsers.PopulateGrid();
               
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
