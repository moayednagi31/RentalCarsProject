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
    public partial class Tenants : Form
    {
        public Tenants()
        {
            InitializeComponent();
        }


        private void btnUsersAdder_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm()
            {
                Text = "Add User",
                users = new Users() { userID = Guid.NewGuid() },
            };
        again:
            var result = usersForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool b = BLogic.addUser(usersForm.users);
                if (b)
                {
                    DataSet ds = BLogic.getUsers("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
                else
                    goto again;
            }

        }
        //find user
        private void btnfind_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.getUsers(btnUsersFind.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnUsersUpdater_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            UsersForm usersForm = new UsersForm()
            {
                Text = "update User",
                updates = true,
                users = new Users()
                {
                    userID = Guid.Parse(row.Cells[0].Value.ToString()),
                    UserName = row.Cells[1].Value.ToString(),
                    UserEmail = row.Cells[2].Value.ToString(),
                    Parole = row.Cells[3].Value.ToString(),
                    Phone = row.Cells[4].Value.ToString(),
                    Address = row.Cells[5].Value.ToString(),
                },
            };
            var result = usersForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool b = BLogic.Updateuser(usersForm.users);
                if (b)
                {

                    row.Cells[1].Value = usersForm.users.UserName;
                    row.Cells[2].Value = usersForm.users.UserEmail;
                    row.Cells[3].Value = usersForm.users.Parole;
                    row.Cells[4].Value = usersForm.users.Phone;
                    row.Cells[5].Value = usersForm.users.Address;


                }

            }

        }
        private void btnUsersDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var result = MessageBox.Show("Do you want to delete seleceted user ", "Confirm the deletion ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool b = BLogic.Deleteuser(ID);
                if (b)
                {
                    DataSet ds = BLogic.getUsers("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tenants_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.getUsers("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnsend_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            users = new Users()
            {
                userID = Guid.Parse(row.Cells[0].Value.ToString()),
                UserName = row.Cells[1].Value.ToString(),
                UserEmail = row.Cells[2].Value.ToString(),
                Parole = row.Cells[3].Value.ToString(),
                Phone = row.Cells[4].Value.ToString(),
                Address = row.Cells[5].Value.ToString(),

            };
            DialogResult = DialogResult.OK;
        }
        public Users users { get; set; }
        private void btncancel_Click(object sender, EventArgs e)
        {


            DialogResult = DialogResult.Cancel;
        }
    }
}
