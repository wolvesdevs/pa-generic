using Generic.Domain.Entities;

namespace Generic.Infrastructure.Csv.ForAbstractClass;

public class ProductCsv1 : CsvBase<ProductEntity>
{
    public IEnumerable GetAll()
    {
        return 
    }

    public override ProductEntity GetEntity()
    {
        throw new NotImplementedException();
    }

    public override string GetFilePath()
    {
        throw new NotImplementedException();
    }

    public override int GetItemLength()
    {
        throw new NotImplementedException();
    }
}

//public class ProductCsv1 : CsvBase<ProductEntity>
//{
//    public override ProductEntity GetEntity(string[] items)
//    {
//        return new ProductEntity(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));
//    }

//    public override int GetItemLength()
//    {
//        return 3;
//    }

//    public override string GetPath()
//    {
//        return "Product.csv";
//    }
//}
