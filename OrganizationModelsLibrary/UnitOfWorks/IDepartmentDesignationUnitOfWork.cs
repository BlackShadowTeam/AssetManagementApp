using Core.Repository.Library.UnitOfWork;
using OrganizationModelsLibrary.Repositorys;

namespace OrganizationModelsLibrary.UnitOfWorks
{
    public interface IDepartmentDesignationUnitOfWork : IUnitOfWork
    {
        IDepartmentRepository Department { get; set; }
        IDesignationRepository Designation { get; set; }
    }
}
