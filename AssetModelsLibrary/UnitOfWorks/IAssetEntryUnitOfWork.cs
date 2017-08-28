using AssetModelsLibrary.Repositorys.AssetEntrys;
using Core.Repository.Library.UnitOfWork;

namespace AssetModelsLibrary.UnitOfWorks
{
    public interface IAssetEntryUnitOfWork : IUnitOfWork
    {
        IAssetEntryRepository AssetEntry { get; set; }
        IAttchmentRepository Attchment { get; set; }
        IFinanceRepository Finance { get; set; }
        INoteRepository Note { get; set; }
    }
}
