using System;

namespace t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Authenticator authenticator1 = Authenticator.GetInstance();
            authenticator1.Authenticate("user1");

            Authenticator authenticator2 = Authenticator.GetInstance();
            authenticator2.Authenticate("user2");

            Console.WriteLine("---------------------");

            if (authenticator1 == authenticator2)
            {
                Console.WriteLine("authenticator1 and authenticator2 are the same instance.");
            }
            else
            {
                Console.WriteLine("authenticator1 and authenticator2 are different instances.");
            }

            Console.ReadLine();
        }
    }
}