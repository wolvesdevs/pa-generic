using Generic.Domain.Repositories;

namespace Generic.Domain.Helper;

public class ProductEntity : IEntity, IDisposable
{
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
