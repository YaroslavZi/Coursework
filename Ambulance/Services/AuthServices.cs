using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Ambulance.Entities;

namespace Ambulance.Services
{
    class AuthServices : IAuthServices
    {
        List<Account> _account = new List<Account>();
        public IEnumerable<Account> GetListAccounts()
        {
            return _account.ToArray();
        }
        public bool Authorize(string login, string password)
        {
            GetAccounts();
            var user = AuthUser(login, password);
            if (user != null)
            {

                return true;
            }
            return false;

        }
        public IEnumerable<Account> GetAccounts()
        {
            if (!File.Exists("account.json"))
            {
                return null;
            }
            using (var f = File.OpenText("account.json"))
            {
                var json = f.ReadToEnd();
                _account = JsonConvert.DeserializeObject<Account[]>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<Account[]>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
        }
        public Account AuthUser(string login, string password)
        {
            return _account.SingleOrDefault(u => u.Login == login && u.Password == password);
        }

    }
}
