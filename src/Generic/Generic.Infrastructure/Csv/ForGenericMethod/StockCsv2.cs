using Generic.Domain.Entities;
using Generic.Domain.Exceptions;

namespace Generic.Infrastructure.Csv.ForGenericMethod;

public class StockCsv2
{


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
