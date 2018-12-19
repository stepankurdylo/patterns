namespace Patterns1
{
    using System;
    using System.Collections.Generic;

    public class HRDepartment : IObserver, IObservable
    {
        List<IObserver> observersForHRDepartment;

        public HRDepartment()
        {
            observersForHRDepartment = new List<IObserver>();
        }

        private void FireWorker()
        {
            Console.WriteLine("You are alredy in the black list. Be careful, don't drink too much :-)");
        }

        public void Update()
        {
            FireWorker();
        }

        public void AddObserver(IObserver observer)
        {
            observersForHRDepartment.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            observersForHRDepartment.ForEach(observer => observer.Update());
        }
    }
}