namespace Patterns1
{
    using System;
    using System.Collections.Generic;

    public class Manager : IObserver, IObservable
    {
        List<IObserver> observersForManager;

        public Manager()
        {
            observersForManager = new List<IObserver>();
        }

        private void GetApprovalForPromotion()
        {
            Console.WriteLine("Get approval for promotion of current worker from manager.");
        }

        public void Update()
        {
            GetApprovalForPromotion();
        }

        public void AddObserver(IObserver observer)
        {
            observersForManager.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            observersForManager.ForEach(observer => observer.Update());
        }
    }
}