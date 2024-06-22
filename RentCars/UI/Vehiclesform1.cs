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
    public partial class Vehiclesform1 : Form
    {
        public Vehiclesform1()
        {
            InitializeComponent();
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        public Vehicles vehicles { get; set; }
        public bool updates { get; set; } = false;
        private void btnsend_Click(object sender, EventArgs e)
        {
            


            if (!ErrorContol(textModel)) return;
            if (!ErrorContol(cbBrand)) return;
            if (!ErrorContol(cbFuelType)) return;
            if (!ErrorContol(nmDailyRate)) return;
            if (!ErrorContol(dtdailyrate)) return;
            if (!ErrorContol(textState)) return;

            vehicles.Model = textModel.Text;
            vehicles.Brand = cbBrand.Text;
            vehicles.FuelType = cbFuelType.Text;
            vehicles.DailyRate = (float)nmDailyRate.Value;
            vehicles.Year = dtdailyrate.Value;
            vehicles.Status = textState.Text;



            DialogResult =DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult =DialogResult.Cancel;
        }

        private bool ErrorContol(Control c)
        {
            if (c is TextBox ||c is ComboBox )
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "You can not let empty");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }

            }
            

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value ==0)
                {
                    errorProvider1.SetError(c, "You can not let empty");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }

            }

            if (c is DateTimePicker)
            {
                if (((DateTimePicker)c).Value == DateTime.MinValue)
                {
                    errorProvider1.SetError(c, "You can not let empty");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }

            }

            return true;

        }

        private void Vehiclesform1_Load(object sender, EventArgs e)
        {

        }
    }
}
