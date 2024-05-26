using Generic.Domain.Entities;
using Generic.Domain.Exceptions;

namespace Generic.Infrastructure.Csv.ForAbstractClass;
public class ProductCsv1 : CsvBase<ProductEntity>
{
    public override string FilePath => "Product.csv";
    public override int ItemCount => 3;

    public override ProductEntity GetEntity(string[] items)
    {
        return new(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));
    }
}

//public class ProductCsv1 : CsvBase<ProductEntity>
//{
//    public override string FilePath => "Product.csv";
//    public override int ItemLength => 3;

//    public override ProductEntity GetEntity(string[] items)
//    {
//        return new ProductEntity(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));
//    }
//}
