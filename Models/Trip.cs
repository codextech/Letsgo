using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsGo.Models
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }

        public string TripName { get; set; }

        public string ImageUrl { get; set; }

        public DateTime TripDate { get; set; }

        public int Price { get; set; }

        public bool Check { get; set; }

        public string CreatedBy { get; set; }

        //show these in Details

        public string Duration { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public string Description { get; set; }

        public string Review { get; set; }

    }
}