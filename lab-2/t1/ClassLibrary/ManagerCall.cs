using System;

namespace ClassLibrary
{
    public class ManagerCall : ISubscriptionFactory
    {
        public Subscription CreateSubscription()
        {
            var subscription = new EducationalSubscription();
            Console.WriteLine("---------------------");
            Console.WriteLine("→Bonus: Personal Consultation!←");
            return subscription;
        }
    }
}