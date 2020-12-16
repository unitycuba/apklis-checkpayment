using UnityEngine;

namespace Apklis.Payment
{
    public class PaymentChecker
    {
        public static PaymentStatus IsPurchased(string packageId)
        {
            var player = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            var activity = player.GetStatic<AndroidJavaObject>("currentActivity");
            
            var verifyClass = new AndroidJavaClass("cu.fluttercuba.apklis_payment_checker.Verify");
            var companionObject = verifyClass.GetStatic<AndroidJavaObject>("Companion");

            // TODO: Use the correct methods to get components for the Pair object
            var result = companionObject.Call<AndroidJavaObject>("isPurchased", activity, packageId).Call<string>("toString"); 

            // removing the parentesis of: (A,B)
            var resultArray = result.Substring(1, result.Length - 2).Split(',');

            var paid = bool.Parse(resultArray[0]);
            var username = resultArray[1];
            
            return new PaymentStatus()
            {
                paid = paid,
                username = username
            };
        }

    }

}