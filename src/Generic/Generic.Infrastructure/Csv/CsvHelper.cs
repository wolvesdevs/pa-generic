using Generic.Domain.Entities;
using Generic.Domain.Exceptions;

namespace Generic.Infrastructure.Csv;

public static class CsvHelper
{


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
    //            throw new Exception("Invalid file format");
    //        }

    //        var entity = func(items);
    //        enitties.Add(entity);
    //    }

    //    return enitties;
    //}
}
