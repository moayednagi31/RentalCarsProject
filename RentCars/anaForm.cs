using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCars.BL;
using RentCars.UI;
using RentCars.DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RentCars
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void anaForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.RentInfo();
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];

            DataSet ds2 = BLogic.paymentinfo();
            if (ds2 != null)
                dataGridView3.DataSource = ds2.Tables[0];


        }


        private void BTN_Click(object sender, EventArgs e)
        {
            new Tenants().ShowDialog();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            new Cars().ShowDialog();

        }
        
        private void btnRents_Click(object sender, EventArgs e)
        {
            RentsForm frm = new RentsForm()
            {
                Text = "Add Rent",
                 Rentals = new Rentals()
                 {
                     RentalID = Guid.NewGuid(),
                 }

            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
            again:
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    bool b = BLogic.rentAdd(frm.Rentals);
                   if (b)
                    {
                        DataSet ds = BLogic.RentInfo();
                        if (ds != null)
                            dataGridView1.DataSource = ds.Tables[0];

                    }
                    else
                        goto again;
                }
            }
        }

        //update rent
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            RentsForm frm = new RentsForm()
            {
                Text = "update rent",
                updates = true,
                Rentals = new Rentals()
                {
                    RentalID = Guid.Parse(row.Cells[0].Value.ToString()),
                    userID = Guid.Parse(row.Cells[1].Value.ToString()),
                    VehicleID = Guid.Parse(row.Cells[2].Value.ToString()),
                    StartDate =DateTime.Parse( row.Cells[6].Value.ToString()),
                    EndDate =DateTime.Parse( row.Cells[7].Value.ToString()),
                    TotalAmount =float.Parse( row.Cells[9].Value.ToString()),
                  
                },
            };
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool b = BLogic.Updaterent(frm.Rentals);
                if (b)
                {

                    row.Cells[1].Value = frm.Rentals.userID;
                    row.Cells[2].Value = frm.Rentals.VehicleID;
                    row.Cells[6].Value = frm.Rentals.StartDate;
                    row.Cells[7].Value = frm.Rentals.EndDate;
                    row.Cells[9].Value = frm.Rentals.TotalAmount;


                }

            }

        }
        //delete rent
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var result = MessageBox.Show("Do you want to delete seleceted rental ", "Confirm the deletion ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool b = BLogic.Deletrent(ID);
                if (b)
                {

                    DataSet ds = BLogic.RentInfo();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }

            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentForm frm = new PaymentForm()
            {
                Text = "Add Payment",
                payments = new Payments()
                {
                    PaymentID = Guid.NewGuid(),
                }

            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
            again:
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    bool b = BLogic.paymentAdd(frm.payments);
                    if (b)
                    {
                        DataSet ds2 = BLogic.paymentinfo();
                        if (ds2 != null)
                            dataGridView3.DataSource = ds2.Tables[0];

                    }
                    else
                        goto again;
                }
            }
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView3.SelectedRows[0];
                   PaymentForm frm = new PaymentForm()
            {
                Text = "update rent",
                updates = true,
                payments = new Payments()
                {
                    PaymentID = Guid.Parse(row.Cells[0].Value.ToString()),
                    userID = Guid.Parse(row.Cells[1].Value.ToString()),
                    PaymentDate = DateTime.Parse(row.Cells[3].Value.ToString()),
                    Amount = float.Parse(row.Cells[4].Value.ToString()),
                    PaymentMethod = row.Cells[5].Value.ToString(),
                   
                    
                },
            };
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool b = BLogic.Updatepayment(frm.payments);
                if (b)
                {

                 
                    row.Cells[1].Value = frm.payments.userID;
                    row.Cells[3].Value = frm.payments.PaymentDate;
                    row.Cells[4].Value = frm.payments.Amount;
                    row.Cells[5].Value = frm.payments.PaymentMethod;


                }

            }

        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var result = MessageBox.Show("Do you want to delete seleceted payment ", "Confirm the deletion ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool b = BLogic.DeletePayment(ID);
                if (b)
                {

                    DataSet ds = BLogic.paymentinfo();
                    if (ds != null)
                        dataGridView3.DataSource = ds.Tables[0];

                }

            }
        }
    }
}
