using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RentCars
{
    public class Users
    { 
        public Guid userID { get; set; }
        public string UserName { get; set; }  
        public string UserEmail { get; set; }
        public string Parole { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{UserName}";
        }
    }
    public class Vehicles
    {

        public Guid VehicleID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string FuelType { get; set; }
        public float DailyRate { get; set; }
        public string Status { get; set;}
        public override string ToString()
        {
            return $"{Brand} {Model}";
        }
    }


    public class Rentals
    {
        public Guid RentalID { get; set; }
        public  Guid userID { get; set; }
        public Guid VehicleID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
       
        public float TotalAmount { get; set; }
      
    }
    public class Payments
    {
        public Guid PaymentID { get; set; }
        public Guid userID { get; set; }
       
        public DateTime PaymentDate { get; set; }
        public float Amount { get; set; }
        public string PaymentMethod { get; set; }
       

    }


}
