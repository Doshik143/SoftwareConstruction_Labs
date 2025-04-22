using System;

namespace ClassLibrary
{
    class ThirdLevelSupport : SupportHandler
    {
        private readonly string[] problems = new string[]
        {
            "No TV Signal",
            "Image Quality Issues",
            "TV Set-top Box Not Working.",
            "Questions About Channel Package"
        };

        public override void HandleRequest(int level)
        {
            if (level == 3)
            {
                Console.Write("\n-------------------------------------------------\n");
                Console.WriteLine("\tConnected to the third level of support.");
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