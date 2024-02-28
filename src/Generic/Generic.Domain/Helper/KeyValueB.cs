namespace Generic.Domain.Helper;

public class KeyValueB<T> where T : class
{
    private T _value;

    public void Run(object o)
    {
        if(_value == null) { }
        if(_value is null) { }
        if(_value is not null) { }
        _value = null;
        var _o = o as T;
    }
}
