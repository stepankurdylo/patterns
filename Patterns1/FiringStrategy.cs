namespace Patterns1
{
    using System;

    public class FiringStrategy : IStrategy
    {
        public bool ActionWithCurrentWorker()
        {
            Console.WriteLine(@"
                Unfortunately, not this time - need to learn some knowledge and have much more expirience.
                You are not the best candidate for this position.
                Try again after five years. Goodbye!");
            return false;
        }
    }
}