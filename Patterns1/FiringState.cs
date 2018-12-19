namespace Patterns1
{
    using System;
    using System.Collections.Generic;

    public class FiringState : BasicState, IObservable
    {
        List<IObserver> unHappyObservers;
        private IStrategy firingStrategy;

        public FiringState(IStrategy comingStrategy) : base(comingStrategy)
        {
            unHappyObservers = new List<IObserver>();
            firingStrategy = comingStrategy;
        }

        public void AddObserver(IObserver observer)
        {
            unHappyObservers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            unHappyObservers.ForEach(observer => observer.Update());
        }

        public override void Update()
        {
            NotifyObservers();
        }
    }
}