using System.Collections.Generic;

namespace ClassLibrary
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            MonthlyFee = 25.00m;
            MinimumPeriod = 6;
            Channels = new List<string> { "Exclusive", "Films", "Serials", "SportsBroadcasts" };
        }
    }
}