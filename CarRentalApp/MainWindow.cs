using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// all codes encapsulated on the obselete codes are not to be used anymore

namespace CarRentalApp
{
    public partial class MainWindow : Form // MainWindow is a class that inheriting from the base class Form
    {
        private Utils _utils; // an instance of the utils so we can access its properties, but you have to initialize it first
        private Login _login; // an instance of the login form

        // publicly accessible property called roleName
        // this allows any window to know what role is the current person logged in 
        public string _roleName;
        private User _user;
        public MainWindow()
        {
            InitializeComponent();
        }

        // this constructor is used to allow mainwindow to have access to login properties and User db information
        public MainWindow(Login login, User user) 
        {
            InitializeComponent();

            _utils = new Utils(); // initialized the utils object to be able to use the properties

            // initialize my local and private log in property
            // It's going to initialize it to the value of the parameter
            // that is coming over in the constructor being initialized here.
            // same function as _db = new CarRentalEntities;
            // but this time you are passing a property/value from
            // the given parameter
            _login = login;
            // same as the above code
            _user = user;



            // uses the User db to connect it ro the Role db and get the shortname
            // gets the user and gets the list of roles and gets the first one
            var role = user.UserRoles.FirstOrDefault(); // embodies what role the user is
            // gets the firstordefault value of shortname from the Role database 
            var roleShortName = role.Role.Shortname;
            _roleName = roleShortName;

            // the three codes above can be inputted like this
            //_roleName = user.UserRoles.FirstOrDefault().Role.Shortname;
        }

        /////////////// Obselete codes //////////////////////////////////////////////////////////
        // made a method for open forms since its always being used
        //private bool FormOpen(String name)
        //{
        //    var OpenForms = Application.OpenForms.Cast<Form>(); // gets the list of object Forms

        //    // boolean, checks if there is an open form called whatever is in the "name" parameter
        //    var isOpen = OpenForms.Any(select => select.Name == name); 

        //    return isOpen;
        //}
        /////////////////////////////////////////////////////////////////////////////////////////


        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // created a class to house the form open method since its being used a lot
            if (!Utils.FormOpen("AddEditRentalRecord"))
            {
                //declares the object
                var addRentalRecord = new AddEditRentalRecord(); // same as AddRentalRecord addRentalRecord = new AddRentalRecord();

                // you can use this but Mdi cannot be used while this is in place
                //addRentalRecord.ShowDialog();

                // tells the object that your Mdi appearance is within the parent ( which is this! )
                addRentalRecord.MdiParent = this; // this keyword is a shortcut, means whatever class you're in (this particular class we are in right now!)
                addRentalRecord.Show();
            }


            /////////////// Obselete codes //////////////////////////////////////////////////////////
            //var OpenForms = Application.OpenForms.Cast<Form>();
            //var isOpen = OpenForms.Any(select => select.Name == "AddEditRentalRecord");

            //if (!FormOpen("AddEditRentalRecord"))
            //{
            //    //declares the object
            //    var addRentalRecord = new AddEditRentalRecord(); // same as AddRentalRecord addRentalRecord = new AddRentalRecord();

            //    // you can use this but Mdi cannot be used while this is in place
            //    //addRentalRecord.ShowDialog();

            //    // tells the object that your Mdi appearance is within the parent ( which is this! )
            //    addRentalRecord.MdiParent = this; // this keyword is a shortcut, means whatever class you're in (this particular class we are in right now!)
            //    addRentalRecord.Show();
            //}
            /////////////////////////////////////////////////////////////////////////////////////////
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormOpen("ManageVehicleListing"))
            {
                var vehicleListing = new ManageVehicleListing();
                vehicleListing.MdiParent = this;
                vehicleListing.Show();
            }

            /////////////// Obselete codes //////////////////////////////////////////////////////////
            //var OpenForms = Application.OpenForms.Cast<Form>(); // gets the list of object Forms
            //var isOpen = OpenForms.Any(select => select.Name == "ManageVehicleListing"); // boolean, checks if there is an open form called ManageVehicleListing

            //if (!FormOpen("ManageVehicleListing")) // if its not open then...
            //{
            //    var vehicleListing = new ManageVehicleListing();
            //    vehicleListing.MdiParent = this;
            //    vehicleListing.Show();
            //}
            /////////////////////////////////////////////////////////////////////////////////////////

        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormOpen("ManageRentalRecord"))
            {
                var manageRentalRecord = new ManageRentalRecord();
                manageRentalRecord.MdiParent = this;
                manageRentalRecord.Show();
            }

            /////////////// Obselete codes //////////////////////////////////////////////////////////
            //var OpenForms = Application.OpenForms.Cast<Form>();
            //var isOpen = OpenForms.Any(select => select.Name == "ManageRentalRecord");

            //if (!FormOpen("ManageRentalRecord"))
            //{
            //    var manageRentalRecord = new ManageRentalRecord();
            //    manageRentalRecord.MdiParent = this;
            //    manageRentalRecord.Show();
            //}
            /////////////////////////////////////////////////////////////////////////////////////////

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }

            /////////////// Obselete codes //////////////////////////////////////////////////////////
            //if (!FormOpen("ManageUsers"))
            //{
            //    var manageUsers = new ManageUsers();
            //    manageUsers.MdiParent = this;
            //    manageUsers.Show();
            //}
            /////////////////////////////////////////////////////////////////////////////////////////

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_user.password == Utils.DefaultHashedPassword())
            {
                var resetPassword = new ResetPassword(_user);
                resetPassword.ShowDialog();
            }

            if (_roleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }

            var username = _user.username;
            toolStripStatusLoginText.Text = $"Logged in as: {username}"; // shows who is logged in on the MainWindow
        }
    }
}
