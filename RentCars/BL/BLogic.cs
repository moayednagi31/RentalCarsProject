using RentCars.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCars.BL
{
    public static  class BLogic
    {
        public static bool addUser (Users m)
        {
            try
            {
                int res = DataLayer.addUser(m);
                return (res > 0);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("There is error" + ex.Message);
                return false;
            }


        }

        internal static bool AddVehicles(Vehicles v)
        {

            try
            {
                int res = DataLayer.AddVehicles(v);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return false;
            }
        }

        internal static bool Deleteuser(string id)
        {

            try
            {
                int res = DataLayer.Deleteuser(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return false;
            }

        }

        internal static bool Deletevehicles(string id)
        {
            try
            {
                int res = DataLayer.Deletevehicles(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return false;
            }
        }

        //to show the users list in the main form 
        internal static DataSet getUsers(string filter)
        {
            try
            {
             DataSet ds  = DataLayer.getUsers(filter);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return null;
            }
        }

        internal static DataSet getVehicles(string filter)
        {

            try
            {
                DataSet ds = DataLayer.getVehicles(filter);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return null;
            }
        }

        internal static bool rentAdd(Rentals r)
        {
            try
            {
                int res = DataLayer.rentAdd(r);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return false;
            }
        }

    
        internal static bool Updateuser(Users m)
        {
            try
            {
                int res = DataLayer.Updateuser(m);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool updateVehicles(Vehicles v)
        {
            try
            {
                int res = DataLayer.updateVehicles(v);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }


        internal static DataSet RentInfo()
        {
            try
            {
                DataSet ds = DataLayer.RentInfo();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return null;
            }
        }

        internal static bool Updaterent(Rentals r)
        {
            try
            {
                int res = DataLayer.Updaterent(r);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool Deletrent(string id)
        {
            try
            {
                int res = DataLayer.Deletrent(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return false;
            }
        }

        internal static bool paymentAdd(Payments p)
        {
            try
            {
                int res = DataLayer.paymentAdd(p);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return false;
            }
        }

        internal static DataSet paymentinfo()
        {
            try
            {
                DataSet ds = DataLayer.paymentinfo();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return null;
            }
        }

        internal static bool Updatepayment(Payments p)
        {

            try
            {
                int res = DataLayer.Updatepayment(p);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool DeletePayment(string id)
        {
            try
            {
                int res = DataLayer.DeletePayment(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
                return false;
            }
        }
    }
}
