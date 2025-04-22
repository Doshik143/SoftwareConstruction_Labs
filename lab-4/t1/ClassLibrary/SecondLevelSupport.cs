using System;

namespace ClassLibrary
{
    class SecondLevelSupport : SupportHandler
    {
        private readonly string[] problems = new string[]
        {
            "Slow Internet",
            "No Internet Connection",
            "Wi-Fi Problems",
            "Questions About Router Setup"
        };

        public override void HandleRequest(int level)
        {
            if (level == 2)
            {
                Console.Write("\n-------------------------------------------------\n");
                Console.WriteLine("\tConnected to second level support.");
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