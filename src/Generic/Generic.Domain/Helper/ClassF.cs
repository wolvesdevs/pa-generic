using Generic.Domain.Repositories;

namespace Generic.Domain.Helper;

public class ClassF<T> where T : class, IEntity, IDisposable
{
    private T _value;
    private List<T> _entities = new();

    public T? Find(int id)
    {
        return _entities.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Add()
    {
        _value.Id = 1;
    }
}
