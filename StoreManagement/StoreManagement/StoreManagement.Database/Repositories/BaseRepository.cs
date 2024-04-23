using Store.Database.Context;

namespace Store.Database.Repositories
{
    public class BaseRepository
    {
        protected readonly StoreDbContext _storeDbContext;

        public BaseRepository(StoreDbContext libraryDbContext)
        {
            this._storeDbContext = libraryDbContext;
        }

        public void SaveChanges()
        {
            _storeDbContext.SaveChanges();
        }
    }
}
