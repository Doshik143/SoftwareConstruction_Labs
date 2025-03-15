using System.Collections.Generic;

namespace ClassLibrary
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            MonthlyFee = 10.00m;
            MinimumPeriod = 1;
            Channels = new List<string> { "Entertainment", "Sport", "News" };
        }
    }
}