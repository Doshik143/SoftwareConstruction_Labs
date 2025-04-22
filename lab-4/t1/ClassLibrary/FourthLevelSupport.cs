using System;

namespace ClassLibrary
{
    class FourthLevelSupport : SupportHandler
    {
        private readonly string[] problems = new string[]
        {
            "Complex Technical Problems With Equipment",
            "Reconfiguring Network Settings",
            "Server-side Problems",
            "Other Complex Technical Issues"
        };

        public override void HandleRequest(int level)
        {
            if (level == 4)
            {
                Console.Write("\n-------------------------------------------------\n");
                Console.WriteLine("\tConnected to the fourth level of support.");
                Console.Write("-------------------------------------------------\n");
                while (!ShowProblemMenu(problems)) { }
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
            else
            {
                Console.WriteLine("Error! Unable Determine Support Level. Please Try Again.");
            }
        }
    }
}