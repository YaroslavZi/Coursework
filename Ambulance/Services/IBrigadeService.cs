using Ambulance.Entities;
using System.Collections.Generic;

namespace Ambulance.Services
{
    interface IBrigadeService
    {
        void AddBrigade(Brigade brigade);
        IEnumerable<Brigade> GetBrigades();
        void RemoveBrigade(int brigadeId);
        int GetMaxId();
    }
}