namespace Patterns1
{
    using System;
    using System.Collections.Generic;

    public class AccountingDepartment : IObserver, IObservable
    {
        List<IObserver> observersForAccountingDepartment;

        public AccountingDepartment()
        {
            observersForAccountingDepartment = new List<IObserver>();
        }

        private void RecalculateSalary()
        {
            Console.WriteLine("Calculates new salary after promotion.");
        }

        public void Update()
        {
            RecalculateSalary();
        }

        public void AddObserver(IObserver observer)
        {
            observersForAccountingDepartment.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            observersForAccountingDepartment.ForEach(observer => observer.Update());
        }
    }
}