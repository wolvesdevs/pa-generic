using Generic.Domain.Repositories;

namespace Generic.Domain.Entities;

public class ProductEntity(int id, string productName, int price) : IEntity, IDisposable
{
    public int Id { get; set; } = id;
    public string ProductName { get; set; } = productName;
    public int Price { get; set; } = price;

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
