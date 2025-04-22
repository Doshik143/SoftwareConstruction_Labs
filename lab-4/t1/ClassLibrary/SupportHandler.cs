using System;

namespace ClassLibrary
{
    abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNextHandler(SupportHandler handler)
        {
            this.nextHandler = handler;
        }

        public abstract void HandleRequest(int level);

        protected bool ShowProblemMenu(string[] problems)
        {
            Console.WriteLine("\n↓-------Choose Your Problem-------↓\n");
            for (int i = 0; i < problems.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {problems[i]}");
            }
            Console.WriteLine("0. Return To Menu");
            Console.Write("\n > ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 0)
                {
                    return false;
                }
                else if (choice >= 1 && choice <= problems.Length)
                {
                    Console.Write("\n-------------------------------------------------\n");
                    Console.WriteLine($"   → Your Choice ~ {problems[choice - 1]} ←");
                    Console.Write("-------------------------------------------------\n");
                    Console.WriteLine("\nOur Specialist Is Already Working On Your Problem ;)");
                    Console.ReadLine();
                    Environment.Exit(0);
                    return true;
                }
                else
                {
                    Console.WriteLine("Error! Incorrect Selection. Please Try Again.");
                    return ShowProblemMenu(problems);
                }
            }
            else
            {
                Console.WriteLine("Error! Please Enter A Number.");
                return ShowProblemMenu(problems);
            }
        }
    }
}