using Generic.Domain.Entities;

namespace Generic.Infrastructure.Csv;

public class StockCsv : CsvBase<StockEntity>
{
    protected override StockEntity GetEntity(string[] items)
    {
        return new StockEntity(Convert.ToInt32(items[0]), Convert.ToInt32(items[1]));
    }

    protected override int GetItemCount()
    {
        return 2;
    }

    protected override string GetPath()
    {
        return "Stock.csv";
    }
}
