using Generic.Domain.Entities;
using Generic.Domain.Exceptions;
using Generic.Domain.Repositories;

namespace Generic.Infrastructure.Csv;

public static class CsvHelper
{
    public static IEnumerable<T> GetAll<T>(string filePath, int itemCount, Func<string[], T> func) where T : IEntity
    {
        var lines = File.ReadAllLines(filePath);
        bool isFirst = true;
        List<T> entities = new();

        foreach (var line in lines)
        {
            if (isFirst)
            {
                isFirst = false;
                continue;
            }

            var items = line.Split(',');
            if (items.Length != itemCount)
            {
                throw new CsvException("ファイルフォーマットが無効です。");
            }

            var stock = func(items);

            entities.Add(stock);
        }

        return entities;
    }

    //public static IEnumerable<T> GetAll<T>(string path, int itemCount, Func<string[], T> func)
    //{
    //    var lines = File.ReadAllLines(path);
    //    bool isFirst = true;
    //    List<T> enitties = new();

    //    foreach (var line in lines)
    //    {
    //        if (isFirst)
    //        {
    //            isFirst = false;
    //            continue;
    //        }

    //        var items = line.Split(',');
    //        if (items.Length != itemCount)
    //        {
    //            throw new CsvException("無効なファイルフォーマットです。");
    //        }

    //        var entity = func(items);
    //        enitties.Add(entity);
    //    }

    //    return enitties;
    //}
}
