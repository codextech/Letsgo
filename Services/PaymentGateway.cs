using Braintree;
using LetsGo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsGo.Services
{
    public class PaymentGateway : IGateway
    {

        /*These API keys have been disabled. Always keep API keys private! Never share them with others or commit them to a public GitHub repository.*/
        private readonly BraintreeGateway _gateway = new BraintreeGateway
        {
            Environment = Braintree.Environment.SANDBOX,
            MerchantId = "3wv4fqk636rn588y",
            PublicKey = "y5yfh9kcnvt8qf4x",
            PrivateKey = "c4660e3571ca74392d20cc91f4568748"
        };

        public PaymentResult ProcessPayment(CheckOutViewModel model)
        {

            var request = new TransactionRequest()
            {
                Amount = model.Total,
                CreditCard = new TransactionCreditCardRequest()
                {
                    Number = model.CardNumber,
                    CVV = model.Cvv,
                    CardholderName = model.CName,
                    ExpirationMonth = model.Month,
                    ExpirationYear = model.Year
                },
                Options = new TransactionOptionsRequest()
                {
                    SubmitForSettlement = true
                }
            };

            var result = _gateway.Transaction.Sale(request);


            if (result.IsSuccess())
            {
                return new PaymentResult(result.Target.Id, true, null);
            }

            return new PaymentResult(null, false, result.Message);

        }
    }
}