using System.Diagnostics;

namespace Generic.Domain.Helper;

public class ClassS
{
    public void Run<T>(T Value)
    {
        Debug.WriteLine(Value.GetType());
    }
}
