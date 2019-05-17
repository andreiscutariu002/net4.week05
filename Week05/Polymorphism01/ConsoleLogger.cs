namespace Polymorphism01
{
    using System;

    public class ConsoleLogger : ILogger
    {
        public void Log(string s)
        {
            Console.WriteLine("### " + s);
        }
    }
}