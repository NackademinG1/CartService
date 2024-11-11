using CartService.Data.Interfaces;

namespace CartService.Data.Repository;

public class ProductRepository<T> : BaseRepository<T>, IProductRepository<T>
{
    // public IEnumerable<T> GetProductsByCategory(string category)
    // {
    //     throw new NotImplementedException();
    // }
    //
    // public void UpdateStock(int productId, int quantity)
    // {
    //     throw new NotImplementedException();
    // }
    //
    // public IEnumerable<T> GetTopSellingProducts(int count)
    // {
    //     throw new NotImplementedException();
    // }
} 