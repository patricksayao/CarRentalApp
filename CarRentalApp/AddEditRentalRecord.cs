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
    public partial class AddEditRentalRecord : Form // AddRentalRecord is a class that is inheritng from a bas class called Form
    {
        private bool isEditMode = true;
        private readonly CarRentalEntities _db; // gives access to every single entity from the diagram its connected to
        public AddEditRentalRecord()
        {
            InitializeComponent();
            this.Text = "Add Rental Record";
            _db = new CarRentalEntities();
            isEditMode = false;
            labelTitle.Text = "Add Rental Record";
        }                           

        public AddEditRentalRecord(CarRentalRecord recordToEdit)
        {
            InitializeComponent();
            this.Text = "Edit Rental Record";
            _db = new CarRentalEntities();
            isEditMode = true;
            labelTitle.Text = "Edit Rental Record";
            PopulateFields(recordToEdit);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = textBoxCustomerName.Text.ToString();
                DateTime dateRent = dateTimePickerRented.Value;
                DateTime dateReturn = dateTimePickerReturned.Value;
                double cost = Convert.ToDouble(textBoxCost.Text);
                bool isValid = true;
                string errorMessage = "";

                // var datatype can be anything
                var carType = comboBoxTypeOfCar.Text;     
                
                // add
                if (string.IsNullOrWhiteSpace(customerName))
                {
                    isValid = false;
                    errorMessage += "\nPlease enter name";
                }

                if (String.IsNullOrWhiteSpace(textBoxCost.Text))
                {
                    isValid = false;
                    errorMessage += "\nPlease Enter a cost";
                }

                if (carType == null)
                {
                    isValid = false;
                    errorMessage += "\nPlease choose a car";
                }

                if (dateReturn < dateRent)
                {
                    isValid = false;
                    errorMessage += "\nIllegal date selection";
                }

                if (isValid) // means if isValid is equals true
                {
                    if (isEditMode)
                    {
                        // edit
                        var id = int.Parse(labelId.Text);
                        var rentalRecord = _db.CarRentalRecords.FirstOrDefault(Select => Select.id == id);
                        //textBoxCustomerName.Text = rental.CustomerName;
                        //textBoxCost.Text = rental.Cost.ToString();
                        //dateTimePickerRented.Value = Convert.ToDateTime(rental.DateRented);
                        //dateTimePickerReturned.Value = Convert.ToDateTime(rental.DateReturned);
                        //comboBoxTypeOfCar.SelectedValue = Convert.ToInt32(rental.TypeOfCarId);

                        //rentalRecord.CustomerName = customerName;
                        //rentalRecord.DateRented = dateRent;
                        //rentalRecord.DateReturned = dateReturn;
                        //rentalRecord.Cost = (decimal)cost; // another type of conversion casting
                        //rentalRecord.TypeOfCarId = (int)comboBoxTypeOfCar.SelectedValue;

                        // above code was compressed into a method
                        PopulateRecord(rentalRecord);

                        _db.SaveChanges();
                        MessageBox.Show("Record has been Edited");
                        Close();
                    }
                    else
                    {
                        // add
                        var rentalRecord = new CarRentalRecord(); // instance of an object from the CarRentalRecord which holds a database

                        // pushes and stores the value from the variables into the rentalRecord object (Database)
                        //rentalRecord.CustomerName = customerName;
                        //rentalRecord.DateRented = dateRent;
                        //rentalRecord.DateReturned = dateReturn;
                        //rentalRecord.Cost = (decimal)cost; // another type of conversion casting
                        //rentalRecord.TypeOfCarId = (int)comboBoxTypeOfCar.SelectedValue; //

                        // above code was compressed into a method
                        PopulateRecord(rentalRecord);

                        _db.CarRentalRecords.Add(rentalRecord); // entity of the whole diagram - entity of the carRentalRecord diagram - add values from rentalRecord object
                        _db.SaveChanges(); // saves any immidiate changes to the database before this code is executed
                                           ////////////////////////////////////////////////////////////////

                        MessageBox.Show($"Thank you for Renting {customerName}\n\n" +
                        $"Car: {carType}\n" +
                        $"Rent Date: {dateRent}\n" +
                        $"Return Date: {dateReturn}\n" +
                        $"Cost: ${cost}");
                        Close();                  
                    }      
                }
                else
                {
                    MessageBox.Show($"Error/s: {errorMessage}");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please input the Cost");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error is: {ex.Message}");                
            }                       
        }       

        private void AddEditRentalRecord_Load(object sender, EventArgs e) // this fires up when the forms load
        {
            // select * from TypeOfCars - in MySQL
            //var cars = _db.TypesOfCars.ToList(); // queries the database for the list of cars
            //comboBoxTypeOfCar.DisplayMember = "Name"; // displays the "Name"
            //comboBoxTypeOfCar.ValueMember = "id"; // stores the "id"
            //comboBoxTypeOfCar.DataSource = cars; // sets the source for the list of items

            // SELECT Id as Id, Make AND Model as Name
            var cars = _db.TypesOfCars
                .Select(select => new
                {
                    Id = select.Id,
                    Name = select.Make + " " + select.Model
                })
                .ToList();

            comboBoxTypeOfCar.DisplayMember = "Name";
            comboBoxTypeOfCar.ValueMember = "Id";
            comboBoxTypeOfCar.DataSource = cars;
        }
        
        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            labelId.Text = recordToEdit.TypeOfCarId.ToString();
            textBoxCustomerName.Text = recordToEdit.CustomerName;
            dateTimePickerRented.Value = Convert.ToDateTime(recordToEdit.DateRented);
            dateTimePickerReturned.Value = Convert.ToDateTime(recordToEdit.DateReturned);
            textBoxCost.Text = Convert.ToString(recordToEdit.Cost);
            comboBoxTypeOfCar.SelectedValue = Convert.ToInt32(recordToEdit.TypeOfCarId);
        }

        private void PopulateRecord(CarRentalRecord rentalRecord)
        {
            string customerName = textBoxCustomerName.Text.ToString();
            DateTime dateRent = dateTimePickerRented.Value;
            DateTime dateReturn = dateTimePickerReturned.Value;
            double cost = Convert.ToDouble(textBoxCost.Text);

            rentalRecord.CustomerName = customerName;
            rentalRecord.DateRented = dateRent;
            rentalRecord.DateReturned = dateReturn;
            rentalRecord.Cost = (decimal)cost; // another type of conversion casting
            rentalRecord.TypeOfCarId = (int)comboBoxTypeOfCar.SelectedValue;
        }
    }
}
