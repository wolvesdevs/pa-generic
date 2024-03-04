using System.Diagnostics;

namespace Generic.Domain.Helper;

public class ClassS<T>
{
    public void Run<TValue>(TValue Value)
    {
        Debug.WriteLine(Value.GetType());
    }

    public void Run<T1, T2>(T1 a, T2 b)
    {
        Debug.WriteLine($"{a.GetType()}: {b.GetType()}");
    }

    public TResult Run<TValue, TResult>(TValue Value)
    {
        Debug.WriteLine(Value.GetType());
        return default;
    }
}
