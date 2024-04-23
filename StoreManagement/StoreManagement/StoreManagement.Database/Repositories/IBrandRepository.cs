using Store.Database.Entities;

namespace Store.Database.Repositories
{
    public interface IBrandRepository
    {
        List<Brand> GetBrands(); 

        int CreateBrand(Brand brand);
    }
}
