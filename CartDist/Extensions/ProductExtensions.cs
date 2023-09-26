using CartDist.Classes;

namespace CartDist.Extensions;

public static class ProductExtensions
{
    public static double Calculate(this int price) => price * 1.25;
    public static double Calculate(this int price, double vat) => price * vat;
    public static double Total(this double price, int count) => price * count;

    public static double Total(this Product product) => product.Price * product.Vat;

}
