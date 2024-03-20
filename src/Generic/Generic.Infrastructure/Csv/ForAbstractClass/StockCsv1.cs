using Generic.Domain.Entities;

namespace Generic.Infrastructure.Csv.ForAbstractClass;

public class StockCsv1 : CsvBase<StockEntity>
{
    public override string FilePath => "Stock.csv";
    public override int ItemLength => 2;

    public override StockEntity GetEntity(string[] items)
    {
        return new StockEntity(Convert.ToInt32(items[0]), Convert.ToInt32(items[1]));
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
