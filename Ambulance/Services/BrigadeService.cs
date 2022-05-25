using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambulance.Data;
using Ambulance.Entities;

namespace Ambulance.Services
{
    class BrigadeService : IBrigadeService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IRepository _repository;
        public BrigadeService()
        {
            _repository = _unitOfWork.Repository;
        }
        public IEnumerable<Brigade> GetBrigades()
        {
            return _repository.GetBrigades();
        }
        public void AddBrigade(Brigade brigade)
        {
            _repository.AddBrigade(brigade);
            _unitOfWork.BrigadesSaveChanges();

        }
        public void RemoveBrigade(int brigadeId)
        {
            _repository.RemoveBrigade(brigadeId);
            _unitOfWork.BrigadesSaveChanges();
        }
        public int GetMaxId()
        {
            return _repository.GetMaxIdBrigade();
        }
    }
}
