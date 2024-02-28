using System.Diagnostics;

namespace Generic.Domain.Helper;

public class E04<T1,T2,T3> where T1 : Delegate where T2 : MulticastDelegate where T3 : Enum
{
    public void Run(int num, T3 t3)
    {
        Debug.WriteLine($"{num}: {t3}");
    }
}
