namespace CartDist.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; init; }
        public double Vat { get; init; }

        public Product(int id, double price, double vat) => (Id, Price, Vat) = (id, price, vat);
    }

    public record class ProductRecord(double price, double vat);
}
