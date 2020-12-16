using UnityEngine;

namespace Apklis.Payment
{
    public class PaymentChecker
    {
        public static PaymentStatus IsPurchased(string packageId)
        {
            var androidClass = new AndroidJavaClass("cu.fluttercuba.apklis_payment_checker.Verify");

            var result =  androidClass.Call<Response> ("isPurchased", packageId);

            return new PaymentStatus() {
                paid = (bool) result.first,
                username = (string) result.second
            };
        }

        private struct Response
        {
            public object first;
            public object second;
        }
    }
    
}