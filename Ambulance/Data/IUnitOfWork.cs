namespace Ambulance.Data
{
    interface IUnitOfWork
    {
        IRepository Repository { get; }
        void BrigadesSaveChanges();
        void CallsSaveChanges();
        void WorkersSaveChanges();
    }
}