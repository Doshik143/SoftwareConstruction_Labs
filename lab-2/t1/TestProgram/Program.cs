using ClassLibrary;
using System;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome! Choose an action↓\n");
                Console.WriteLine("1. Subscribe");
                Console.WriteLine("2. View all subscription types");
                Console.WriteLine("3. Exit");
                Console.WriteLine("-------");
                Console.Write("→ ");
                int mainChoice = int.Parse(Console.ReadLine());

                switch (mainChoice)
                {
                    case 1:
                        CreateSubscription();
                        break;
                    case 2:
                        ViewAllSubscriptions();
                        break;
                    case 3:
                        Console.WriteLine("Thank you for using our service♥!");
                        return;
                    default:
                        Console.WriteLine("Error! Try again.\n");
                        break;
                }
            }
        }

        static void CreateSubscription()
        {
            int subscriptionChoice = 0;
            int creationMethodChoice = 0;
            //ChooseSubscriptionTypes
            while (true)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("↓Choose a subscription type↓\n");
                Console.WriteLine("1. Domestic Subscription");
                Console.WriteLine("2. Premium Subscription");
                Console.WriteLine("3. Educational Subscription");
                Console.WriteLine("-------");
                Console.Write("→ ");
                if (int.TryParse(Console.ReadLine(), out subscriptionChoice) && subscriptionChoice >= 1 && subscriptionChoice <= 3)
                    break;
                Console.WriteLine("Error! Try again.\n");
            }
            //ChoiceOfDesignMethod
            while (true)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("↓Choose a registration method↓\n");
                Console.WriteLine("1. Through the WebSite");
                Console.WriteLine("2. Through the MobileApp");
                Console.WriteLine("3. Through the ManagerCall");
                Console.WriteLine("-------");
                Console.Write("→ ");
                if (int.TryParse(Console.ReadLine(), out creationMethodChoice) && creationMethodChoice >= 1 && creationMethodChoice <= 3)
                    break;
                Console.WriteLine("Error! Try again.\n");
            }
            ISubscriptionFactory factory = null;
            Subscription subscription = null;
            //ChoosingFactory
            switch (creationMethodChoice)
            {
                case 1:
                    factory = new WebSite();
                    break;
                case 2:
                    factory = new MobileApp();
                    break;
                case 3:
                    factory = new ManagerCall();
                    break;
            }
            //ChoosingSubscription
            switch (subscriptionChoice)
            {
                case 1:
                    subscription = factory.CreateSubscription();
                    break;
                case 2:
                    subscription = factory.CreateSubscription();
                    break;
                case 3:
                    subscription = factory.CreateSubscription();
                    break;
            }
            //InformationAboutSubscription
            Console.WriteLine("---------------------");
            Console.WriteLine("Your subscription has been successfully completed!☻↓");
            subscription.DisplayInfo();

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        static void ViewAllSubscriptions()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("↓Available subscription types↓");
            //CreatingAllTypesOfSubscriptions
            Subscription domestic = new DomesticSubscription();
            Subscription premium = new PremiumSubscription();
            Subscription educational = new EducationalSubscription();
            //InformationAboutAllSubscription
            Console.WriteLine("\n------->Domestic Subscription<-------");
            domestic.DisplayInfo();

            Console.WriteLine("\n------->Premium Subscription<-------");
            premium.DisplayInfo();

            Console.WriteLine("\n------->Educational Subscription<-------");
            educational.DisplayInfo();

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}