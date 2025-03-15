using System.Collections.Generic;

namespace ClassLibrary
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            MonthlyFee = 15.00m;
            MinimumPeriod = 3;
            Channels = new List<string> { "Science", "Documentary", "Educational" };
        }
    }
}