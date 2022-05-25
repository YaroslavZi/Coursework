using System.Collections.Generic;
using Ambulance.Entities;

namespace Ambulance.Services
{
    interface IAuthServices
    {
        bool Authorize(string login, string password);
        IEnumerable<Account> GetAccounts();
        IEnumerable<Account> GetListAccounts();
    }
}