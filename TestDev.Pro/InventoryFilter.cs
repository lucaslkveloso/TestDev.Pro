using TestDev.Pro.Model;

namespace TestDev.Pro
{
    public class InventoryFilter
    {
        public List<Product> FilterProducts(List<Product> products, string sortKey, bool ascending)
        {
            Func<Product, object> orderByKeySelector = sortKey switch
            {
                "name" => p => p.Name,
                "price" => p => p.Price,
                "stock" => p => p.StockQuantity,
                _ => products => products
            };

            if (orderByKeySelector == null)
            {
                return products;
            }


            if (ascending)
            {
                return products.OrderBy(orderByKeySelector).ToList();
            }
            else
            {
                return products.OrderByDescending(orderByKeySelector).ToList();
            }
        }
    }
}
