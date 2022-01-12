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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode; // for tracking purposes (adding or editing)
        private ManageVehicleListing _manageVehicleListing;
        private readonly CarRentalEntities _db; // same as private readonly CarRentalEntities _db = new CarRentalEntities

        // this method is for adding/inserting data
        public AddEditVehicle(ManageVehicleListing manageVehicleListing)
        {
            InitializeComponent();
            this.Text = "Add New Vehicle";
            labelTitle.Text = "Add New Vehicle"; // when the form initializes, the text would be this one
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalEntities(); // initializes the database in this particular method
        }

        // method overloading
        // this method is for editing/updating data so it uses a different query
        public AddEditVehicle(TypesOfCar carToEdit, ManageVehicleListing manageVehicleListing)
        {
            InitializeComponent();
            this.Text = "Edit Vehicle";
            labelTitle.Text = "Edit Vehicle"; // when this particular form initializes, the text would be this one
            isEditMode = true;
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalEntities(); // initializes the database in this particular method
            PopulateFields(carToEdit);
        }

        private void PopulateFields(TypesOfCar car)
        {
            labelId.Text = car.Id.ToString(); // tracks the item being edited (to use in buttonSaveChanges_Click method)
            textBoxMake.Text = car.Make;
            textBoxModel.Text = car.Model;
            textBoxVin.Text = car.VIN;
            textBoxYear.Text = car.Year; // ToString is used for int(any numerals) to string
            textBoxLicensePlateNumber.Text = car.LiscensePlateNumber;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // if (isEditMode == true)
                if (isEditMode)
                {
                    // edit here
                    var id = int.Parse(labelId.Text); // int.parse is used for string to int
                    var car = _db.TypesOfCars.FirstOrDefault(select => select.Id == id);
                    car.Make = textBoxMake.Text;
                    car.Model = textBoxModel.Text;
                    car.VIN = textBoxVin.Text;
                    car.Year = textBoxYear.Text;
                    car.LiscensePlateNumber = textBoxLicensePlateNumber.Text;

                    if (String.IsNullOrWhiteSpace(textBoxMake.Text) || 
                        String.IsNullOrWhiteSpace(textBoxModel.Text) ||
                        String.IsNullOrWhiteSpace(textBoxVin.Text) ||
                        String.IsNullOrWhiteSpace(textBoxYear.Text) ||
                        String.IsNullOrWhiteSpace(textBoxLicensePlateNumber.Text))
                    {
                        MessageBox.Show("Please Complete the Record");
                    }
                    else
                    {
                        _db.SaveChanges(); // saves the changes up to this point
                        _manageVehicleListing.PopulateGrid();
                        this.Close();
                    }                                     
                }
                else
                {
                    // add here
                    var newCar = new TypesOfCar
                    {
                        Make = textBoxMake.Text,
                        Model = textBoxModel.Text,
                        VIN = textBoxVin.Text,
                        Year = textBoxYear.Text,
                        LiscensePlateNumber = textBoxLicensePlateNumber.Text
                    };

                    if (String.IsNullOrWhiteSpace(textBoxMake.Text) ||
                        String.IsNullOrWhiteSpace(textBoxModel.Text) ||
                        String.IsNullOrWhiteSpace(textBoxVin.Text) ||
                        String.IsNullOrWhiteSpace(textBoxYear.Text) ||
                        String.IsNullOrWhiteSpace(textBoxLicensePlateNumber.Text))
                    {
                        MessageBox.Show("Please Complete the Record");
                    }
                    else
                    {
                        _db.TypesOfCars.Add(newCar); // adds the record to the TypesOfCar database
                        _db.SaveChanges(); // saves the changes up to this point
                        _manageVehicleListing.PopulateGrid();
                        this.Close();
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                //throw;
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // .Close() closes the window
        }
    }
}
