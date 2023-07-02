using ASP.NET_Core_with_Angular.Models;

namespace ASP.NET_Core_with_Angular.Services.Infrastructure
{
    public interface ICartItem
    {
        IEnumerable<CartItem> GetCartItems();
        CartItem GetCartItem(int id);

        void insert(CartItem cartItem);
        void update(CartItem cartItems);
        void detele(int id);

        int Count();
        void Save();
    }
}
