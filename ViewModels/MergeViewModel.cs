using LetsGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsGo.ViewModels
{
    public class MergeViewModel
    {
        public Trip Trips { get; set; }

        public Booked Book { get; set; }

        public RegisterViewModel Register { get; set; }

        public LoginViewModel Login { get; set; }

    }
}