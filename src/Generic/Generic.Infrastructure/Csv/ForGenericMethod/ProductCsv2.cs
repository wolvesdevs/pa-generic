using Generic.Domain.Entities;
using Generic.Domain.Exceptions;

namespace Generic.Infrastructure.Csv.ForGenericMethod;

public class ProductCsv2
{
    public object GetAll()
    {
        var lines = File.ReadAllLines("Product.csv");
        bool isFirst = true;
        List<ProductEntity> entities = new();

        foreach (var line in lines)
        {
            if (isFirst)
            {
                isFirst = false;
                continue;
            }

            var items = line.Split(',');
            if (items.Length != 3)
            {
                throw new CsvException("ファイルフォーマットが無効です。");
            }

            ProductEntity product = new(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));

            entities.Add(product);
        }

        return entities;
    }

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
