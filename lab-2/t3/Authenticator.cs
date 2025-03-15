using System;

namespace t3
{
    public sealed class Authenticator
    {
        private static Authenticator _instance;

        private static readonly object _lock = new object();

        private Authenticator()
        {
            Console.WriteLine("Authenticator instance created.");
            Console.WriteLine("---------------------");
        }

        public static Authenticator GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }
        public void Authenticate(string username)
        {
            Console.WriteLine($"User '{username}' authenticated.");
        }
    }
}