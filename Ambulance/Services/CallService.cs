using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambulance.Data;
using Ambulance.Entities;

namespace Ambulance.Services
{
    class CallService : ICallService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IRepository _repository;

        public CallService()
        {
            _repository = _unitOfWork.Repository;
        }
        public IEnumerable<Call> GetCalls()
        {
            return _repository.GetCalls();
        }
        public void AddCall(Call call)
        {
            _repository.AddCall(call);
            _unitOfWork.CallsSaveChanges();
        }
        public void RemoveCall(int callId)
        {
            _repository.RemoveCall(callId);
            _unitOfWork.CallsSaveChanges();
        }
        public int GetMaxId()
        {
            return _repository.GetMaxIdCall();
        }
    }
}