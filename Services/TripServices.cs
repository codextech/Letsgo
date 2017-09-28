using LetsGo.Models;
using LetsGo.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LetsGo.Services
{
    public class TripServices
    {


        private readonly ApplicationDbContext _db;


        public TripServices(ApplicationDbContext Context)
        {
            _db = Context;
        }

        // Dependency Resolve

        public TripServices() : this(new ApplicationDbContext())
        {

        } 


        public async Task<IEnumerable<Trip>> GetTrips()
        {
            return await _db.Trips.ToArrayAsync();
        }



        public async Task<Trip> GetTripDetails(int tripId)
        {

            return await _db.Trips.SingleOrDefaultAsync(t => t.Id == tripId);

        }




        //Checking Out

        public async Task<PaymentResult> CheckoutAsync(CheckOutViewModel model)
        {


            var booked = new Booked()
            {

                Name = model.Name,
                Email = model.Email,
                Mobile = model.Mobile,
                Address = model.Address,
                Persons = model.Persons

            };



            //To Authorize paymment
            var gateway = new PaymentGateway();
            var result = gateway.ProcessPayment(model);

            if (result.Succeeded)
            {
                booked.TransactionId = result.TransactionId;
                _db.Books.Add(booked);
                await _db.SaveChangesAsync();

            }

            return result;




        }




    }
}