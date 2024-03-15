using Generic.Domain.Entities;

namespace Generic.Infrastructure.Csv.ForGenericMethod;

public class ProductCsv2
{
    public IEnumerable<ProductEntity> GetAll()
    {
        IEnumerable<ProductEntity> entities = CsvHelper.GetAll("Product.csv", 3, (string[] items) => 
            new ProductEntity(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2])));

        return entities;
    }

    //public IEnumerable<ProductEntity> GetAll()
    //{
    //    return CsvHelper.GetAll("Product.csv", 3, GetEntity);
    //}

    //public ProductEntity GetEntity(string[] items)
    //{
    //    return new ProductEntity(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));
    //}
}
