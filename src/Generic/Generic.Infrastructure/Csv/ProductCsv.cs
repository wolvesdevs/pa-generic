using Generic.Domain.Entities;

namespace Generic.Infrastructure.Csv;

public class ProductCsv : CsvBase<ProductEntity>
{
    protected override ProductEntity GetEntity(string[] items)
    {
        return new ProductEntity(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));
    }

    protected override int GetItemCount()
    {
        return 3;
    }

    protected override string GetPath()
    {
        return "Product.csv";
    }
}
