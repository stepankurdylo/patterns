namespace Patterns1
{
    public abstract class BasicState : IState
    {
        private IStrategy currentStrategy;

        public BasicState(IStrategy comingStrategy)
        {
            currentStrategy = comingStrategy;
        }

        public virtual void ApplyStrategy()
        {
            currentStrategy.ActionWithCurrentWorker();
            Update();
        }

        public abstract void Update();
    }
}