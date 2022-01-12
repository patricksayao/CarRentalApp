using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// obselete codes are not used anymore but preserved for posterity purposes

namespace CarRentalApp
{
    public partial class ManageRentalRecord : Form
    {
        private readonly CarRentalEntities _db;
        private Utils _utils; // an instance of the utils so we can access its properties, but you have to initialize it first
        public ManageRentalRecord()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            _utils = new Utils(); // initialized the utils object to be able to use the properties
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            // made the form open put into another class and just call it from that
            // class whenever needed to
            if (!Utils.FormOpen("AddEditRentalRecord"))
            {
                //visual studio recommended format
                var addEditRentalRecord = new AddEditRentalRecord
                {
                    MdiParent = this.MdiParent
                };

                addEditRentalRecord.Show();
            }

            ////////////// obsolete code////////////////////
            //    if (!IsFormOpened("AddEditRentalRecord")) // made the open form into a method
            //{

            //}
            /////////////////////////////////////////////////

        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utils.FormOpen("AddEditRentalRecord"))
                {
                    var id = (int)dataGridViewRecordListing.SelectedRows[0].Cells["id"].Value;

                    var carRent = _db.CarRentalRecords.FirstOrDefault(select => select.id == id);

                    var addEditRentalRecord = new AddEditRentalRecord(carRent);
                    addEditRentalRecord.MdiParent = this.MdiParent;
                    addEditRentalRecord.Show();
                }

                ////////////// obsolete code////////////////////
                //var OpenForms = Application.OpenForms.Cast<Form>();
                //var isOpen = OpenForms.Any(select => select.Name == "AddEditRentalRecord");
                //if (!IsFormOpened("AddEditRentalRecord"))
                //{
                    
                //}
                /////////////////////////////////////////////////
            }            
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                MessageBox.Show("Please Select a row to edit");                
                //throw;
            }
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dataGridViewRecordListing.SelectedRows[0].Cells["id"].Value;

                var carRent = _db.CarRentalRecords.FirstOrDefault(select => select.id == id);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this particulat record",
                     "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    _db.CarRentalRecords.Remove(carRent);
                    _db.SaveChanges();
                }
                //dataGridViewRecordListing.Refresh();
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
            PopulateGrid();
        }

        private void ManageRentalRecord_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            var carRentalRecord = _db.CarRentalRecords
                .Select(select => new
                {
                    Id = select.id,
                    CustomerName = select.CustomerName,
                    dateRent = select.DateRented,
                    dateReturn = select.DateReturned,
                    select.Cost,
                    // select.TypesOfCar.Make is an inner join statement
                    // whenever there is a link(foreign key) to another database you can use it
                    Car = select.TypesOfCar.Make + " " + select.TypesOfCar.Model
                })
                .ToList();

            dataGridViewRecordListing.DataSource = carRentalRecord;

            dataGridViewRecordListing.Columns["CustomerName"].HeaderText = "Customer Name";
            dataGridViewRecordListing.Columns["dateRent"].HeaderText = "Date Rent";
            dataGridViewRecordListing.Columns["dateReturn"].HeaderText = "Date Return";
            dataGridViewRecordListing.Columns["Id"].Visible = false;
        }

        ////////////// obsolete code////////////////////
        //private bool IsFormOpened(String name)
        //{
        //    var OpenForms = Application.OpenForms.Cast<Form>();
        //    var isOpen = OpenForms.Any(select => select.Name == name);
        //    return isOpen;
        //}
        /////////////////////////////////////////////////

    }
}
