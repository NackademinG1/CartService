using CartService.Data.Interfaces;

namespace CartService.Data.Repository;

public class CartRepository<T> : BaseRepository<T>, ICartRepository<T>
{
    
}