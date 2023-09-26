using System.Diagnostics.Metrics;

namespace CartDist.Classes;

public class Cart
{
    List<CartItem> _cart = new();
    public List<CartItem> CartItems => _cart.GetRange(0, _cart.Count);

    public void Add(Product p, int count)
    {
        var id = _cart.Count == 0 ? 1 : _cart.Max(p => p.Id) + 1;
        var item = new CartItem(id, p, count);
        _cart.Add(item);
    }

    public void Remove(int id)
    {
        if (!_cart.Any(p => p.Id.Equals(id))) return;

        var item = _cart.Single(p => p.Id.Equals(id));

        _cart.Remove(item);
    }
}
