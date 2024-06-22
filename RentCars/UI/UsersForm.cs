using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace RentCars.UI
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            textID.Text = users.userID.ToString();
            if (updates)
            {
           textName.Text =    users.UserName ;
           textEmail.Text   =  users.UserEmail  ;
          textParole.Text  =    users.Parole ;
          textTel.Text    =  users.Phone  ;
            textAddress.Text  =  users.Address ;


            }

        }
        public Users users { get; set; }
        public bool updates { get; set; } = false;

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (!ErrorContol(textName))return;
            if (!ErrorContol(textEmail)) return;
            if (!ErrorContol(textParole)) return;
            if (!ErrorContol(textTel)) return;
            if (!ErrorContol(textAddress)) return;

            users.UserName = textName.Text;
            users.UserEmail = textEmail.Text;
            users.Parole = textParole.Text;
            users.Phone = textTel.Text;
            users.Address = textAddress.Text;


           DialogResult = DialogResult.OK;
        }

        private bool ErrorContol (Control c)
        {
            if (c is TextBox)
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

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull )
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
        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult =DialogResult.Cancel;
        }
    }
}
