using Generic.Domain.Entities;
using Generic.Domain.Exceptions;

namespace Generic.Infrastructure.Csv.ForGenericMethod;

public class ProductCsv2
{

    
    //public IEnumerable<ProductEntity> GetAll()
    //{
    //    return CsvHelper.GetAll("Product.csv", 3, items => new ProductEntity(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2])));
    //}

    //public IEnumerable<ProductEntity> GetAll()
    //{
    //    return CsvHelper.GetAll("Product.csv", 3, GetEntity);
    //}

    //private ProductEntity GetEntity(string[] items)
    //{
    //    return new(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));
    //}
}
