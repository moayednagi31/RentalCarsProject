using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace RentCars.DL
{
  public static class DataLayer
    {

        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "localhost", // kendi server IP'niz
                Database = "carrentaldb",    // veri tabanı adı
                UserID = "root",
                Password = "123456",

            }.ConnectionString
            );
        public static int addUser(Users m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("Usersadd", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.userID);
                komut.Parameters.AddWithValue("@nam", m.UserName);
                komut.Parameters.AddWithValue("@mail", m.UserEmail);
                komut.Parameters.AddWithValue("@paro", m.Parole);
                komut.Parameters.AddWithValue("@tel", m.Phone);
                komut.Parameters.AddWithValue("@adr", m.Address);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int AddVehicles(Vehicles v)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("AddVehicles", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", v.VehicleID);
                komut.Parameters.AddWithValue("@bra", v.Brand);
                komut.Parameters.AddWithValue("@model", v.Model);
                komut.Parameters.AddWithValue("@yea", v.Year);
                komut.Parameters.AddWithValue("@fuel", v.FuelType);
                komut.Parameters.AddWithValue("@dail", v.DailyRate);
                komut.Parameters.AddWithValue("@stat", v.Status);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int Deleteuser(string id)
        {

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("Deleteuser", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);
         

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        
    }

        internal static int Deletevehicles(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("Deletevehicles", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet getUsers(string filter)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filter))
                {

              //get user

                komut = new MySqlCommand("Userall", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
              

                }else
                {
                    komut = new MySqlCommand("getUsers", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filter", filter);
                }

                 DataSet dataSet = new DataSet();
                 MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet getVehicles(string filter)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filter))
                {

                    //get user

                    komut = new MySqlCommand("VehiclesAll", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;


                }
                else
                {
                    komut = new MySqlCommand("findVehicles", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filter", filter);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

     

        internal static int Updateuser(Users m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("Updateuser", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.userID);
                komut.Parameters.AddWithValue("@nam", m.UserName);
                komut.Parameters.AddWithValue("@mail", m.UserEmail);
                komut.Parameters.AddWithValue("@paro", m.Parole);
                komut.Parameters.AddWithValue("@tel", m.Phone);
                komut.Parameters.AddWithValue("@adr", m.Address);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int updateVehicles(Vehicles v)
        {

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("updateVehicles", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", v.VehicleID);
                komut.Parameters.AddWithValue("@bra", v.Brand);
                komut.Parameters.AddWithValue("@model", v.Model);
                komut.Parameters.AddWithValue("@yea", v.Year);
                komut.Parameters.AddWithValue("@fuel", v.FuelType);
                komut.Parameters.AddWithValue("@dail", v.DailyRate);
                komut.Parameters.AddWithValue("@stat", v.Status);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }


        internal static int rentAdd(Rentals r)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("rentAdd", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@rid", r.RentalID);
                komut.Parameters.AddWithValue("@uid", r.userID);
                komut.Parameters.AddWithValue("@vid", r.VehicleID);
                komut.Parameters.AddWithValue("@stard", r.StartDate);
                komut.Parameters.AddWithValue("@endat", r.EndDate);
                komut.Parameters.AddWithValue("@totalam", r.TotalAmount);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

                internal static DataSet RentInfo()
                {
                    try
                    {
                        if (conn.State != System.Data.ConnectionState.Open)
                            conn.Open();


                        //get user

                        MySqlCommand komut = new MySqlCommand("RentInfo", conn);
                        komut.CommandType = System.Data.CommandType.StoredProcedure;




                        DataSet dataSet = new DataSet();
                        MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                        adp.Fill(dataSet);
                        return dataSet;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        if (conn.State != System.Data.ConnectionState.Closed)
                            conn.Close();
                    }
                }

        internal static int Updaterent(Rentals r)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("Updaterent", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@rid", r.RentalID);
                komut.Parameters.AddWithValue("@uid", r.userID);
                komut.Parameters.AddWithValue("@vid", r.VehicleID);
                komut.Parameters.AddWithValue("@stard", r.StartDate);
                komut.Parameters.AddWithValue("@endat", r.EndDate);
                komut.Parameters.AddWithValue("@totalam", r.TotalAmount);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int Deletrent(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("Deletrent", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int paymentAdd(Payments p)
        {

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("paymentAdd", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@pid", p.PaymentID);
                komut.Parameters.AddWithValue("@rid", p.userID);
                komut.Parameters.AddWithValue("@dt", p.PaymentDate);
                komut.Parameters.AddWithValue("@amont", p.Amount);
                komut.Parameters.AddWithValue("@method", p.PaymentMethod);
               
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet paymentinfo()
        {

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();


                //get user

                MySqlCommand komut = new MySqlCommand("paymentinfo", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;




                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int Updatepayment(Payments p)
        {

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("Updatepayment", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@pid", p.PaymentID);
                komut.Parameters.AddWithValue("@rid", p.userID);
                komut.Parameters.AddWithValue("@dt", p.PaymentDate);
                komut.Parameters.AddWithValue("@amont", p.Amount);
                komut.Parameters.AddWithValue("@method", p.PaymentMethod);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int DeletePayment(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("DeletePayment", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@pid", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
    }
}
