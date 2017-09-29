using Bapstore.Data.Infrastructure;
using Bapstore.Data.Repository;
using Bapstore.Model.Models;

namespace Bapstore.Service
{
    public interface IErrorService
    {
        Error Create(Error error);
        void Save();
    }

    public class ErrorService : IErrorService
    {
        IErrorRepository _errorRepository;
        IUnitOfWork _unitOfWork;

        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            _errorRepository = errorRepository;
            _unitOfWork = unitOfWork;
        }

        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
