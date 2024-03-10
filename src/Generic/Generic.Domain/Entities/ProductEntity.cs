using Generic.Domain.Repositories;

namespace Generic.Domain.Entities;

public class ProductEntity(int id, string productName, int price) : IEntity
{
    public ProductEntity() : this(0, "", 0) { }
    public ProductEntity(int id) : this(id, "", 0) { }
    public ProductEntity(int id, string productName) : this(id, productName, 0) { }

    public int Id { get; set; } = id;
    public string ProductName { get; set; } = productName;
    public int Price { get; set; } = price;
}
