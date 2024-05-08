using TestDev.Pro.Model;

namespace TestDev.Pro
{
    public class Program 
    {
        static void Main(string[] args)
        {
            List<Product> products =
            [
                new("CPU", 100.00, 5),
                new Product("RAM", 42.70, 10),
                new Product("Case", 150.99, 3),
                new Product("Motherboard", 89.10, 100),
                new Product("Power Suply", 89.00, 7)
            ];

            InventoryFilter inventoryFilter = new InventoryFilter();

            List<Product> filteredProducts = inventoryFilter.FilterProducts(products, "name", true);

            foreach (Product product in filteredProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, StockQuantity: {product.StockQuantity}");
            }
        }
    }
}
