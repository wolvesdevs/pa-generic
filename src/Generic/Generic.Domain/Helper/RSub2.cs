using Generic.Domain.Repositories;

namespace Generic.Domain.Helper;

public class RSub2<T1, T2> : RBase<T1, T2> where T1 : IEntity, IDisposable where T2 : IDisposable
{

}
