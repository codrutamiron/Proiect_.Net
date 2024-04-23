using Store.Database.Context;
using Store.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Store.Database.Repositories
{
    public class BrandRepository : BaseRepository, IBrandRepository
    {
        public BrandRepository(StoreDbContext storeDbContext) : base(storeDbContext)
        {
        }

        public List<Brand> GetBrands()
        {
            var result = _storeDbContext.Brands
                .Include(a => a.Article)
                .AsNoTracking()
                .ToList();

            return result;
        }

        public int CreateBrand(Brand brand)
        {
            _storeDbContext.Brands.Add(brand);
            _storeDbContext.SaveChanges();

            return brand.Id;
        }
    }
}
