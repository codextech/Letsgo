using LetsGo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsGo.Services
{
    interface IGateway
    {
        PaymentResult ProcessPayment(CheckOutViewModel model);
    }
}