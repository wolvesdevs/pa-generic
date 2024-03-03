using Generic.Domain.Repositories;

namespace Generic.Domain.Entities;

public class ProductEntity(int id) : IEntity, IDisposable
{
    private int _id = id;

    public ProductEntity() : this(0) { }

    public int Id { get; set; } = id;

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
