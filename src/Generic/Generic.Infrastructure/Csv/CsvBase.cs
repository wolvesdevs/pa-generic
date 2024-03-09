using Generic.Domain.Entities;
using Generic.Domain.Exceptions;
using Generic.Domain.Repositories;

namespace Generic.Infrastructure.Csv
{
    public abstract class CsvBase<T> where T : IEntity
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

                var entity = GetEntity(items);
                
                entities.Add(entity);
            }

            return entities;
        }

        protected abstract string GetPath();
        protected abstract int GetItemCount();
        protected abstract T GetEntity(string[] items);
    }
}
