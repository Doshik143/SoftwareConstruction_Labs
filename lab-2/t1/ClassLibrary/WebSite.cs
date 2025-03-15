using System;

namespace ClassLibrary
{
    public class WebSite : ISubscriptionFactory
    {
        public Subscription CreateSubscription()
        {
            var subscription = new DomesticSubscription();
            subscription.MonthlyFee *= 0.9m; //Sale 10%
            Console.WriteLine("---------------------");
            Console.WriteLine("→Bonus: Sale 10%!←");
            return subscription;
        }
    }
}