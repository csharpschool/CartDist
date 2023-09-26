namespace CartDist.Classes
{
    public class Shop
    {
        List<Product> _products = new();
        Cart _cart;

        public Shop(Cart cart)
        {
            _cart = cart;
        }

        public List<Product> Products => _products.GetRange(0, _products.Count);

        Product? CreateProduct(double? price = null, double? vat = null)
        {
            if (price is null || vat is null) return null;

            var id = _products.Count == 0 ? 1 : _products.Max(p => p.Id) + 1;
            return new Product(id, (double)price, (double)vat);
        }

        public void AddProduct(double? price = null, double? vat = null)
        {
            var prod = CreateProduct(price, vat);
            if(prod is not null) _products.Add(prod); 
        }

        public void AddToCart(int id, int count)
        {
            /*if (count < 1) return;
            if(!_products.Any(p => p.Id.Equals(id))) return;*/

            if (count < 1 || !_products.Any(p => p.Id.Equals(id))) return;

            var prod = _products.Single(p => p.Id.Equals(id));

            _cart.Add(prod, count);
        }

        public List<CartItem> CartItems => _cart.CartItems;

        public void RemoveCartItem(int id) => _cart.Remove(id);
        
    }
}
