using Generic.Domain.Entities;

namespace Generic.Infrastructure.Csv;

public class StockCsv : CsvBase<StockEntity>
{
    public override StockEntity GetEntity(string[] items)
    {
        return new StockEntity(Convert.ToInt32(items[0]), Convert.ToInt32(items[1]));
    }

    public override int GetItemLength()
    {
        return 2;
    }

    public override string GetPath()
    {
        return "Stock.csv";
    }
}
