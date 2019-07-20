using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void Save();
    }

    internal class ErrorService : IErrorService
    {
        private IErrorRepository _errorRepository;
        private IUnitOfWork _UnitOfWork;

        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._UnitOfWork = unitOfWork;
        }

        public Error Create(Error error)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}