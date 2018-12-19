namespace Patterns1
{
    using System;
    using System.Collections.Generic;

    public class Worker : IObserver
    {
        private IState workerState;
        List<IObserver> observersForWorker;

        public Worker()
        {
            observersForWorker = new List<IObserver>();
        }

        public bool IsPassedPDP { get; set; }

        public void TryToPromote()
        {
            if (IsPassedPDP == true)
            {
                workerState = new PromotionState(observersForWorker, new PromotionStrategy());
                var manager = new Manager();
                manager.AddObserver(this);
                (workerState as PromotionState).AddObserver(manager);
                (workerState as PromotionState).AddObserver(new AccountingDepartment());
            }
            else
            {
                workerState = new FiringState(new FiringStrategy());
                (workerState as FiringState).AddObserver(new HRDepartment());
            }
            workerState.ApplyStrategy();
        }

        private void GetSalary()
        {
            Console.WriteLine("Get me my money, I has already passed everything.");
        }

        public void Update()
        {
            GetSalary();
        }
    }
}