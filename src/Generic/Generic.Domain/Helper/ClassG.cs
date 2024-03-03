using Generic.Domain.Repositories;

namespace Generic.Domain.Helper;

public class ClassG<T> where T : IEntity, new()
{
    private T _value = new();
    private List<T> _entities = new();

    public T FindData(int id)
    {
        var result = _entities.FirstOrDefault(e => e.Id == id);

        if (result is null)
        {
            return new T();
        }

        return result;
    }
}
