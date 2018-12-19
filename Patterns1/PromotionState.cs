namespace Patterns1
{
    using System;
    using System.Collections.Generic;

    public class PromotionState : BasicState, IObservable
    {
        List<IObserver> happyObservers;
        private IStrategy promotionStrategy;

        public PromotionState(List<IObserver> observersForWorker, IStrategy comingStrategy) : base(comingStrategy)
        {
            happyObservers = observersForWorker;
            promotionStrategy = comingStrategy;
        }

        public void AddObserver(IObserver observer)
        {
            happyObservers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            happyObservers.ForEach(observer => observer.Update());
        }

        public override void Update()
        {
            NotifyObservers();
        }
    }
}