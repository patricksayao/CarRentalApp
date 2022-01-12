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
    public partial class ManageVehicleListing : Form // launches the program
    {
        // gives access to every single entity from the diagram its connected to
        private readonly CarRentalEntities _db; // you can name the object whatever you want to name it (in this case its _db)

        private Utils _utils;

        public ManageVehicleListing() // launches the manage vehivle listing program and runs whatever is inside the method
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            _utils = new Utils();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            // SELECT * from CarRentalRecords
            //var cars = _db.TypesOfCars.ToList(); // list the types of cars inside the database

            // SELECT Id as CarID, name as CarName FROM TypeOfCars
            //var cars = _db.TypesOfCars
            //    .Select(select => new { CarId = select.Id, CarName = select.Make }) // lambda expression where we create an object
            //    .ToList();

            // This is a much more complete format from the database compared to the other two above
            // SELECT Id, Make as Make, Model as Model, VIN as VIN, LicensePlateNumber as LicensePlateNumber, Year as Year FROM TypeOfCars
            //var cars = _db.TypesOfCars
            //    .Select(select => new
            //    {                    
            //        Make = select.Make,
            //        Model = select.Model,
            //        VIN = select.VIN,                    
            //        Year = select.Year,
            //        LicensePlateNumber = select.LiscensePlateNumber,
            //        select.Id
            //    })
            //    .ToList();

            //// dataGridViewVehicleListing.Show();
            //dataGridViewVehicleListing.DataSource = cars;

            //// how to change the name of a table (in the form only, not in the database)          
            //dataGridViewVehicleListing.Columns[4].HeaderText = "License Plate Number";
            //dataGridViewVehicleListing.Columns[5].Visible = false;


            // made the above code as a method because the code was used more than once
            PopulateGrid();
        }

        // generally adds an entry
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            if (!Utils.FormOpen("AddEditVehicle"))
            {
                // add "this" parameter so that instance so we may access whetever public method we have in ManageVehicleListing form
                var addEditVehicle = new AddEditVehicle(this); // same as  AddEditVehicle addEditVehicle = new AddEditVehicle            
                addEditVehicle.MdiParent = this.MdiParent; // this.MdiParent = MainWindow
                addEditVehicle.Show();
            }

            /////////////////   Obsolete code   ////////////////////////////////////////////////////////////////////////
            //var OpenForms = Application.OpenForms.Cast<Form>();
            //var isOpen = OpenForms.Any(select => select.Name == "AddEditVehicle");
            //if (!isOpen)
            //{
            //    // add "this" parameter so that instance so we may access whetever public method we have in ManageVehicleListing form
            //    var addEditVehicle = new AddEditVehicle(this); // same as  AddEditVehicle addEditVehicle = new AddEditVehicle            
            //    addEditVehicle.MdiParent = this.MdiParent; // this.MdiParent = MainWindow
            //    addEditVehicle.Show();
            //}            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        // - selects the id to be edited
        private void buttonEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utils.FormOpen("AddEditVehicle"))
                {
                    // get Id of the selected row 
                    // gets the value from the selected row(first selected row) to a cell called Id from the selected row
                    // its parsed as an integer to correlate to the datatype of the value we have in the database
                    var id = (int)dataGridViewVehicleListing.SelectedRows[0].Cells["Id"].Value;

                    // query database for record
                    // what firstOrDefault does is we get a value or we get null
                    var car = _db.TypesOfCars.FirstOrDefault(select => select.Id == id); // compares the int column to int value            

                    // launch AddEditVehicle window with data
                    var addEditVehicle = new AddEditVehicle(car, this); // adding the variable car to the parameter lets it know that editing is being done
                    addEditVehicle.MdiParent = this.MdiParent;
                    addEditVehicle.Show();
                }

                /////////////////   Obsolete code   ////////////////////////////////////////////////////////////////////////
                //var OpenForms = Application.OpenForms.Cast<Form>();
                //var isOpen = OpenForms.Any(select => select.Name == "AddEditVehicle");
                //if (!isOpen)
                //{
                //    // get Id of the selected row 
                //    // gets the value from the selected row(first selected row) to a cell called Id from the selected row
                //    // its parsed as an integer to correlate to the datatype of the value we have in the database
                //    var id = (int)dataGridViewVehicleListing.SelectedRows[0].Cells["Id"].Value;

                //    // query database for record
                //    // what firstOrDefault does is we get a value or we get null
                //    var car = _db.TypesOfCars.FirstOrDefault(select => select.Id == id); // compares the int column to int value            

                //    // launch AddEditVehicle window with data
                //    var addEditVehicle = new AddEditVehicle(car, this); // adding the variable car to the parameter lets it know that editing is being done
                //    addEditVehicle.MdiParent = this.MdiParent;
                //    addEditVehicle.Show();
                //}
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select a row to edit");
                //
                //MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                //throw;
            }            
        }

        // deletes entry
        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dataGridViewVehicleListing.SelectedRows[0].Cells["Id"].Value;

                var car = _db.TypesOfCars.FirstOrDefault(select => select.Id == id);

                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete This Record?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    // removes the particular selected row
                    _db.TypesOfCars.Remove(car);
                    // saves the changes
                    _db.SaveChanges();
                }
                // refresh the form
                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a row to delete");
                //throw;
            }            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewVehicleListing.Refresh();
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var cars = _db.TypesOfCars
                .Select(select => new
                {
                    Make = select.Make,
                    Model = select.Model,
                    VIN = select.VIN,
                    Year = select.Year,
                    LicensePlateNumber = select.LiscensePlateNumber,
                    select.Id
                })
                .ToList();

            // dataGridViewVehicleListing.Show();
            dataGridViewVehicleListing.DataSource = cars;

            // how to change the name of a table (in the form only, not in the database)          
            dataGridViewVehicleListing.Columns[4].HeaderText = "License Plate Number";
            dataGridViewVehicleListing.Columns[5].Visible = false;
            //throw new NotImplementedException();
        }
    }
}
