using Generic.Domain.Repositories;

namespace Generic.Domain.Helper;

public class ClassK<T1, T2> where T1 : class, IEntity, new() where T2 : IDisposable, new()
{

}
