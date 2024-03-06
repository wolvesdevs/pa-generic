using Generic.Domain.Repositories;

namespace Generic.Domain.Entities;

public class StockEntity(int id, string name) : IEntity
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
