using Core.Repository.Library.UnitOfWork;
using OrganizationModelsLibrary.Repositorys;

namespace OrganizationModelsLibrary.UnitOfWorks
{
    public interface IOrgnationUnitOfWork : IUnitOfWork
    {
        IOrganizationRepository Orgnation { get; set; }
        IBranchRepository Branch { get; set; }
    }
}
