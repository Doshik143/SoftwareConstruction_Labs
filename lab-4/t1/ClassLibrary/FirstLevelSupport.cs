using System;

namespace ClassLibrary
{
    class FirstLevelSupport : SupportHandler
    {
        private readonly string[] problems = new string[]
        {
            "Error In Expense",
            "Payment Problem",
            "Refund Request",
            "Questions About Tariffs"
        };

        public override void HandleRequest(int level)
        {
            if (level == 1)
            {
                Console.Write("\n-------------------------------------------------\n");
                Console.WriteLine("\tConnected To First Level Of Support.");
                Console.Write("-------------------------------------------------\n");
                while (!ShowProblemMenu(problems)) { }
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
        }
    }
}