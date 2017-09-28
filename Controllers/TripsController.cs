using LetsGo.Services;
using LetsGo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LetsGo.Controllers
{
    public class TripsController : Controller
    {

        private readonly TripServices _services;

        public TripsController(TripServices Services)
        {
            _services = Services;
        }

        // Dependency Resolve
        public TripsController() : this(new TripServices())
        {

        }





        // GET: Trips
        public async Task<ActionResult> Index()
        {

            var trips = await _services.GetTrips();

            return View(trips);
        }


        public async Task<ActionResult> Details(int tripId)
        {

            var detail = await _services.GetTripDetails(tripId);

          
            return View(detail);
        }



        //For checking Out

        public ActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Checkout(CheckOutViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _services.CheckoutAsync(model);

            if (result.Succeeded)
            {
                TempData["transactionId"] = result.TransactionId;
                return RedirectToAction("Complete");
            }

            ModelState.AddModelError(String.Empty, result.Message);

            return View(model);


        }

        //Other Actoins

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }



    }
}