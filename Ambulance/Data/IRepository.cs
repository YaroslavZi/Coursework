using Ambulance.Entities;
using System.Collections.Generic;

namespace Ambulance.Data
{
    interface IRepository
    {
        void AddBrigade(Brigade brigade);
        void AddCall(Call call);
        void AddWorker(Worker worker);
        IEnumerable<Brigade> GetBrigades();
        IEnumerable<Call> GetCalls();
        IEnumerable<Worker> GetWorkers();
        IEnumerable<Call> GetListCalls();
        IEnumerable<Worker> GetListWorkers();
        IEnumerable<Brigade> GetListBrigades();
        void RemoveBrigade(int id);
        void RemoveCall(int id);
        void RemoveWorker(int id);
        int GetMaxIdCall();
        int GetMaxIdWorker();
        int GetMaxIdBrigade();
    }
}