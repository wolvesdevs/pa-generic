using Generic.Domain.Entities;
using Generic.Domain.Exceptions;

namespace Generic.Infrastructure.Csv
{
    public abstract class CsvBase<T>
    {
        public IEnumerable<T> GetAll()
        {
            var lines = File.ReadAllLines(GetPath());
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
                if (items.Length != GetItemCount())
                {
                    throw new CsvException();
                }

                var product = GetEntity(items);

                entities.Add(product);
            }

            return entities;
        }

        protected abstract string GetPath();
        protected abstract int GetItemCount();
        protected abstract T GetEntity(string[] items);
    }
}
