using Generic.Domain.Entities;
using Generic.Domain.Exceptions;
using Generic.Domain.Repositories;

namespace Generic.Infrastructure.Csv
{
    public abstract class CsvBase<T>
    {
        public IEnumerable<T> GetAll()
        {
            var lines = File.ReadAllLines(GetPath());
            bool isFirst = true;
            List<T> enitties = new();

            foreach (var line in lines)
            {
                if (isFirst)
                {
                    isFirst = false;
                    continue;
                }

                var items = line.Split(',');
                if (items.Length != GetItemLength())
                {
                    throw new Exception("Invalid file format");
                }

                var entity = GetEntity(items);
                enitties.Add(entity);
            }

            return enitties;
        }

        public abstract string GetPath();
        public abstract int GetItemLength();
        public abstract T GetEntity(string[] items);
    }
}
