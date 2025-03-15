using System;

namespace ClassLibrary
{
    public class MobileApp : ISubscriptionFactory
    {
        public Subscription CreateSubscription()
        {
            var subscription = new PremiumSubscription();
            subscription.Channels.Add("BonusChannel (OnlyForMobileApp)");
            Console.WriteLine("---------------------");
            Console.WriteLine("→Bonus: BonusChannel!←");
            return subscription;
        }
    }
}