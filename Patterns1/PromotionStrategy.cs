namespace Patterns1
{
    using System;

    public class PromotionStrategy : IStrategy
    {
        public bool ActionWithCurrentWorker()
        {
            Console.WriteLine("Thanks God. He has already passed this PDP!");
            return true;
        }
    }
}