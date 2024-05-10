using Generic.Domain.Entities;
using Generic.Domain.Exceptions;

namespace Generic.Infrastructure.Csv.ForGenericMethod;

public class StockCsv2
{
    public IEnumerable<StockEntity> GetAll()
    {
        var lines = File.ReadAllLines("Stock.csv");
        bool isFirst = true;
        List<StockEntity> entities = new();

        foreach (var line in lines)
        {
            if (isFirst)
            {
                isFirst = false;
                continue;
            }

            var items = line.Split(',');
            if (items.Length != 2)
            {
                throw new CsvException("ファイルフォーマットが無効です。");
            }

            StockEntity stock = new(Convert.ToInt32(items[0]), Convert.ToInt32(items[1]));

            entities.Add(stock);
        }

        return entities;
    }

    //public IEnumerable<StockEntity> GetAll()
    //{
    //    return CsvHelper.GetAll("Stock.csv", 2, items => new StockEntity(Convert.ToInt32(items[0]), Convert.ToInt32(items[1])));
    //}

    //public IEnumerable<StockEntity> GetAll()
    //{
    //    return CsvHelper.GetAll("Stock.csv", 2, GetEntity);
    //}

    //private StockEntity GetEntity(string[] items)
    //{
    //    return new(Convert.ToInt32(items[0]), Convert.ToInt32(items[1]));
    //}
}
