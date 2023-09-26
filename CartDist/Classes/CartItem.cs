namespace CartDist.Classes
{
    public class CartItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }

        public double Total => Count * Product.Price;

        public CartItem(int id, Product p, int count) => (Id, Product, Count) = (id, p, count);
    }
}
