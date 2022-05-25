using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Data
{
    class UnitOfWork : IUnitOfWork
    {
        public IRepository Repository { get; } = new Repository();

        public void WorkersSaveChanges()
        {
            var workers = Repository.GetListWorkers();

            var json = JsonConvert.SerializeObject(workers, Formatting.Indented,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            using (var f = File.CreateText("workersData.json"))
            {
                f.Write(json);
            }
        }
        public void CallsSaveChanges()
        {
            var calls = Repository.GetListCalls();

            var json = JsonConvert.SerializeObject(calls, Formatting.Indented,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            using (var f = File.CreateText("callsData.json"))
            {
                f.Write(json);
            }
        }
        public void BrigadesSaveChanges()
        {
            var brigades = Repository.GetListBrigades();

            var json = JsonConvert.SerializeObject(brigades, Formatting.Indented,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            using (var f = File.CreateText("brigadesData.json"))
            {
                f.Write(json);
            }
        }
    }
}