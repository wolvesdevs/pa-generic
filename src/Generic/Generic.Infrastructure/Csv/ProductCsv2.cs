using Generic.Domain.Entities;

namespace Generic.Infrastructure.Csv;

public class ProductCsv2
{
    public IEnumerable<ProductEntity> GetAll()
    {
        //return CsvHelper.GetAll("Product,csv", 3, GetEntity);
        return CsvHelper.GetAll("Product.csv", 3, (string[] x) =>
        {
            return new ProductEntity(Convert.ToInt32(x[0]), x[1], Convert.ToInt32(x[2]));
        });
    }

    private ProductEntity GetEntity(string[] items)
    {
        return new ProductEntity(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));
    }
}
