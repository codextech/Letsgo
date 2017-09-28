using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsGo.Models
{
    public class Booked
    {
        [Key]
        public int Id { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime BookedDate { get; set; }

     
        public string TransactionId { get; set; }

 
        public string Name { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public int Persons { get; set; }

        public int City { get; set; }

        public decimal Total { get; set; }

        //Foriegn Key

        public int TripId { get; set; }


        public Trip Events { get; set; }

    }
}