using System;

namespace ClassLibrary
{
    public class SupportSystem
    {
        private SupportHandler handlerChain;

        public SupportSystem()
        {
            var level1 = new FirstLevelSupport();
            var level2 = new SecondLevelSupport();
            var level3 = new ThirdLevelSupport();
            var level4 = new FourthLevelSupport();

            level1.SetNextHandler(level2);
            level2.SetNextHandler(level3);
            level3.SetNextHandler(level4);

            this.handlerChain = level1;
        }

        public void Start()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n↓-------Please Select Type Your Problem-------↓\n");
                Console.WriteLine("1. Bill/Payment");
                Console.WriteLine("2. Internet");
                Console.WriteLine("3. Television");
                Console.WriteLine("4. Complex Technical Problems");
                Console.WriteLine("0. Exit");
                Console.Write("\n > ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 0)
                    {
                        exit = true;
                        Console.Write("\n-------------------------------------------------\n");
                        Console.WriteLine("\t   Thank You For Your Contact.\n\t\tHave A Nice Day!");
                    }
                    else if (choice >= 1 && choice <= 4)
                    {
                        handlerChain.HandleRequest(choice);
                    }
                    else
                    {
                        Console.WriteLine("Error!\nIncorrect Selection.\nPlease Try Again.");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter A Number!");
                }
            }
        }
    }
}