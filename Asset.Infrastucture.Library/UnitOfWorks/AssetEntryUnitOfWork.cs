using Asset.Infrastucture.Library.Repositorys.AssetEntys;
using AssetDatabaseContextLibrary;
using AssetModelsLibrary.Repositorys.AssetEntrys;
using AssetModelsLibrary.UnitOfWorks;

namespace Asset.Infrastucture.Library.UnitOfWorks
{
    public class AssetEntryUnitOfWork : IAssetEntryUnitOfWork
    {
        private readonly AssetDbContext _context;

        public AssetEntryUnitOfWork(AssetDbContext context)
        {
            _context = context;
            AssetEntry = new AssetEntryRepository(_context);
            Attchment = new AttchmentRepository(_context);
            Finance = new FinanceRepository(_context);
            Note = new NoteRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public IAssetEntryRepository AssetEntry { get; set; }
        public IAttchmentRepository Attchment { get; set; }
        public IFinanceRepository Finance { get; set; }
        public INoteRepository Note { get; set; }
    }
}
