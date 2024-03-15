using Generic.Domain.Entities;
using Generic.Domain.Exceptions;
using Generic.Domain.Repositories;

namespace Generic.Infrastructure.Csv
{
    public abstract class CsvBase<T>
    {
        public IEnumerable GetAll()
        {
            var lines = File.ReadAllLines(GetFilePath());
            //var lines = File.ReadAllLines("Product.csv");
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
                if (items.Length != GetItemLength())
                //if (items.Length != 3)
                {
                    throw new CsvException();
                }

                //ProductEntity product = new(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));

                entities.Add(GetEntity());
            }

            return entities;
        }

        public abstract string GetFilePath();
        public abstract int GetItemLength();
        public abstract T GetEntity();
    }

    //public abstract class CsvBase<T> where T : IEntity
    //{
    //    public IEnumerable<T> GetAll()
    //    {
    //        var lines = File.ReadAllLines(GetPath());
    //        bool isFirst = true;
    //        List<T> enitties = new();

    //        foreach (var line in lines)
    //        {
    //            if (isFirst)
    //            {
    //                isFirst = false;
    //                continue;
    //            }

    //            var items = line.Split(',');
    //            if (items.Length != GetItemLength())
    //            {
    //                throw new Exception("Invalid file format");
    //            }

    //            var entity = GetEntity(items);
    //            enitties.Add(entity);
    //        }

    //        return enitties;
    //    }

    //    public abstract string GetPath();
    //    public abstract int GetItemLength();
    //    public abstract T GetEntity(string[] items);
    //}
}
