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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }


        private void textID_TextChanged(object sender, EventArgs e)
        {

        }
        public Payments payments {  get; set; }
        public bool updates { get; set; } = false;
        private void btnsend_Click(object sender, EventArgs e)
        {
            if (nmamount.Value == 0)
            {
                errorProvider1.SetError(nmamount, "please enter the price !");
                nmamount.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmamount, "");
            }
            if (cbpaymentmethod.SelectedItem == null)
            {
                errorProvider1.SetError(cbpaymentmethod, "please choose payment method");
                cbpaymentmethod.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbpaymentmethod, "");
                

            }
            payments.userID= Guid.Parse( textrent.Text);
            payments.PaymentDate =dtspaymenttime.Value;
            payments.Amount = (float)nmamount.Value;
            payments.PaymentMethod = cbpaymentmethod.Text;


            DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            
           
            textID.Text = payments.PaymentID.ToString();
            if (updates)
            {
                textrent.Text = payments.userID.ToString();
                dtspaymenttime.Value= payments.PaymentDate;
                nmamount.Value = (decimal)payments.Amount;
                cbpaymentmethod.Text = payments.PaymentMethod;
                

            }
        }

        private void btnChooseRent_Click(object sender, EventArgs e)
        {
            Tenants frm = new Tenants();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
                textrent.Text = frm.users.userID.ToString();
            }

        }
    }
}
