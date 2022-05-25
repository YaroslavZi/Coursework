using Ambulance.Entities;
using System.Collections.Generic;

namespace Ambulance.Services
{
    interface ICallService
    {
        void AddCall(Call call);
        IEnumerable<Call> GetCalls();
        void RemoveCall(int callid);
        int GetMaxId();
    }
}