using Ambulance.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Data
{
    class Repository : IRepository
    {
        private List<Call> _calls = new List<Call>();
        private List<Worker> _workers = new List<Worker>();
        private List<Brigade> _brigades = new List<Brigade>();
        public IEnumerable<Worker> GetWorkers()
        {
            using (var f = File.OpenText("workersData.json"))
            {
                var json = f.ReadToEnd();
                _workers = JsonConvert.DeserializeObject<Worker[]>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<Worker[]>(json,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
        }
        public IEnumerable<Call> GetCalls()
        {
            using (var f = File.OpenText("callsData.json"))
            {
                var json = f.ReadToEnd();
                _calls = JsonConvert.DeserializeObject<Call[]>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<Call[]>(json,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
        }
        public IEnumerable<Brigade> GetBrigades()
        {
            using (var f = File.OpenText("brigadesData.json"))
            {
                var json = f.ReadToEnd();
                _brigades = JsonConvert.DeserializeObject<Brigade[]>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<Brigade[]>(json,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
        }
        public void AddWorker(Worker worker)
        {
            _workers.Add(worker);
        }
        public void AddCall(Call call)
        {
            _calls.Add(call);
        }
        public void AddBrigade(Brigade brigade)
        {
            _brigades.Add(brigade);
        }

        public void RemoveWorker(int id)
        {
            var worker = _workers.FirstOrDefault(w => w.Id == id);

            if (worker != null)
            {
                _workers.Remove(worker);
            }
        }
        public void RemoveCall(int id)
        {
            var call = _calls.FirstOrDefault(w => w.Id == id);

            if (call != null)
            {
                _calls.Remove(call);
            }
        }
        public void RemoveBrigade(int id)
        {
            var brigade = _brigades.FirstOrDefault(b => b.Id == id);

            if (brigade != null)
            {
                _brigades.Remove(brigade);
            }
        }
        public IEnumerable<Call> GetListCalls()
        {
            return _calls.ToArray();
        }
        public IEnumerable<Worker> GetListWorkers()
        {
            return _workers.ToArray();
        }
        public IEnumerable<Brigade> GetListBrigades()
        {
            return _brigades.ToArray();
        }

        public int GetMaxIdCall()
        {
            int temp = GetCalls().Max(call => call.Id); 
            return temp;
        }

        public int GetMaxIdWorker()
        {
            int temp = GetWorkers().Max(worker => worker.Id); 
            return temp;
        }

        public int GetMaxIdBrigade()
        {
            int temp = GetBrigades().Max(brigade => brigade.Id); 
            return temp;
        }

        public IEnumerable<Call> GetListReaders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Brigade> GetListBooks()
        {
            throw new NotImplementedException();
        }
    }
}