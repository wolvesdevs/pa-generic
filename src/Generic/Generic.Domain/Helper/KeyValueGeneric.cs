namespace Generic.Domain.Helper;

public class KeyValueGeneric<T>
{
    private T _value;
    private List<T> _values = new();

    public int Key { get; set; }
    public T Value { get; set; }
    public T Value2 { get; set; }

    public event Action<T> MyAction;

    public override string ToString()
    {
        return $"ID = {Key}, Value = {Value}";
    }

    public void Add(T value)
    {
        _values.Add(value);
    }

    public T GetValue(int index)
    {
        return _values[index];
    }
}
