using Generic.Domain.Entities;

namespace Generic.Infrastructure.Csv;

public class StockCsv2
{
    public IEnumerable<StockEntity> GetAll()
    {
        return CsvHelper.GetAll("Stock.csv", 2, (string[] x) =>
        {
            return new StockEntity(Convert.ToInt32(x[0]), Convert.ToInt32(x[1]));
        });
    }
}
