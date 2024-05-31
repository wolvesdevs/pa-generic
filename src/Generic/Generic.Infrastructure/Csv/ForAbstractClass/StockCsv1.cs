using Generic.Domain.Entities;
using Generic.Domain.Exceptions;

namespace Generic.Infrastructure.Csv.ForAbstractClass;
public class StockCsv1 : CsvBase<StockEntity>
{
    public override string FilePath => "Stock.csv";
    public override int ItemCount => 2;

    public override StockEntity GetEntity(string[] items)
    {
        return new(Convert.ToInt32(items[0]), Convert.ToInt32(items[1])); ;
    }
}

//public class StockCsv1 : CsvBase<StockEntity>
//{
//    public override string FilePath => "Stock.csv";
//    public override int ItemLength => 2;

//    public override StockEntity GetEntity(string[] items)
//    {
//        return new StockEntity(Convert.ToInt32(items[0]), Convert.ToInt32(items[1]));
//    }
//}
