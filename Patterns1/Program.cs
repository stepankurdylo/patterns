namespace Patterns1
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var worker = new Worker();
            worker.IsPassedPDP = true;
            worker.TryToPromote();
            Console.ReadKey();
        }
    }
}