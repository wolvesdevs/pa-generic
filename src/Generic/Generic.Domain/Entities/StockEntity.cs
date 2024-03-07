using Generic.Domain.Repositories;

namespace Generic.Domain.Entities;

public class StockEntity(int id, int stockCount) : IEntity
{
    public int Id { get; set; } = id;
    public int StockCount { get; set; } = stockCount;

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
