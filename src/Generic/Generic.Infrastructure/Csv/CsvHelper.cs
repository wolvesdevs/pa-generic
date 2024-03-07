using Generic.Domain.Exceptions;

namespace Generic.Infrastructure.Csv;

public static class CsvHelper
{
    public static IEnumerable<T> GetAll<T>(string path, int itemCount, Func<string[], T> func)
    {
        var lines = File.ReadAllLines(path);
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
                throw new CsvException();
            }

            var entity = func(items);

            entities.Add(entity);
        }

        return entities;
    }
}
