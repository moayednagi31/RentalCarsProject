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

    public partial class RentsForm : Form
    {

        
        public RentsForm()
        {
            InitializeComponent();
        }

        private void RentsForm_Load(object sender, EventArgs e)
        {
           
           
            textID.Text = Rentals.RentalID.ToString();
            if (updates)
            {
                textuser.Text = Rentals.userID.ToString();
                textvenhicle.Text = Rentals.VehicleID.ToString();
                nmtotalamount.Value = (decimal)Rentals.TotalAmount;
                dtstarttime.Value = Rentals.StartDate;
                dtendtime.Value = Rentals.EndDate;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textModel_TextChanged(object sender, EventArgs e)
        {

        }
        public bool updates {  get; set; } = false;
        public Rentals Rentals {  get; set; }
      //  public Users users { get; set; }
      //  public Vehicles vehicles { get; set; }
        

        private void btnsend_Click(object sender, EventArgs e)
        {
            if(nmtotalamount.Value == 0)
            {
                errorProvider1.SetError(nmtotalamount, "please enter the price !");
                nmtotalamount.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmtotalamount, "");
            }

            Rentals.StartDate =dtstarttime.Value;
            Rentals.EndDate = dtendtime.Value;
            Rentals.userID =Guid.Parse(textuser.Text);
            Rentals.VehicleID  =Guid.Parse(textvenhicle.Text);
           
            Rentals.TotalAmount = (float)nmtotalamount.Value;


            
            DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void btnChooseCar_Click(object sender, EventArgs e)
        {
            Cars frm = new Cars();
            if (frm.ShowDialog() == DialogResult.OK)
            {
              //  vehicles =frm.vehicles;
                textvenhicle.Text = frm.vehicles.VehicleID.ToString();
            }
        }

        private void btnChooseUser_Click(object sender, EventArgs e)
        {
            Tenants frm = new Tenants();
            if (frm.ShowDialog() == DialogResult.OK)
            {
             //  users = frm.users;
                textuser.Text = frm.users.userID.ToString();
            }

        }
    }
}
