using RentCars.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCars.UI
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.getVehicles("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        //find vehicles
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.getVehicles(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        //this is addAddVehicles
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            Vehiclesform1 frm = new Vehiclesform1()
            {
                Text = "Add User",
                vehicles = new Vehicles() { VehicleID = Guid.NewGuid() },
            };
        again:
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool b = BLogic.AddVehicles(frm.vehicles);
                if (b)
                {
                    DataSet ds = BLogic.getVehicles("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }
                else
                    goto again;
            }

        }

        private void UpdateVehicles_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView2.SelectedRows[0];
            Vehiclesform1 frm = new Vehiclesform1()
            {
                Text = "update Vehicles ",
                updates = true,
                vehicles = new Vehicles()
                {
                    VehicleID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Brand = row.Cells[1].Value.ToString(),
                    Model = row.Cells[2].Value.ToString(),
                    Year = (DateTime)row.Cells[3].Value,
                    FuelType = row.Cells[4].Value.ToString(),
                    DailyRate = (float)row.Cells[5].Value,
                    Status = row.Cells[6].Value.ToString(),
                },
            };
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool b = BLogic.updateVehicles(frm.vehicles);
                if (b)
                {


                    row.Cells[1].Value = frm.vehicles.Brand;
                    row.Cells[2].Value = frm.vehicles.Model;
                    row.Cells[3].Value = frm.vehicles.Year;
                    row.Cells[4].Value = frm.vehicles.FuelType;
                    row.Cells[5].Value = frm.vehicles.DailyRate;
                    row.Cells[6].Value = frm.vehicles.Status;


                }

            }

        }

        private void vehiclesdelete_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var result = MessageBox.Show("Do you want to delete seleceted vehicel ", "Confirm the deletion ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool b = BLogic.Deletevehicles(ID);
                if (b)
                {
                    DataSet ds = BLogic.getVehicles("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }

            }
        }
        public Vehicles vehicles { get; set; }  
        private void btnsend_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            
                vehicles = new Vehicles()
                {
                    VehicleID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Brand = row.Cells[1].Value.ToString(),
                    Model = row.Cells[2].Value.ToString(),
                    Year = (DateTime)row.Cells[3].Value,
                    FuelType = row.Cells[4].Value.ToString(),
                    DailyRate = (float)row.Cells[5].Value,
                    Status = row.Cells[6].Value.ToString(),
               
            };
            DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
