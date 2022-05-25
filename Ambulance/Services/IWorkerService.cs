using Ambulance.Entities;
using System.Collections.Generic;

namespace Ambulance.Services
{
    interface IWorkerService
    {

        void AddWorker(Worker worker);

        IEnumerable<Worker> GetWorkers();

        void RemoveWorker(int id);
        int GetMaxId();
    }
}