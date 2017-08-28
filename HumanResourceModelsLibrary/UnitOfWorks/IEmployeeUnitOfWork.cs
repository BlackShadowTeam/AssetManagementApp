using Core.Repository.Library.UnitOfWork;
using HumanResourceModelsLibrary.Repositorys;

namespace HumanResourceModelsLibrary.UnitOfWorks
{
    public interface IEmployeeUnitOfWork : IUnitOfWork
    {
        IEmployeeRepository Employee { get; set; }
    }
}
