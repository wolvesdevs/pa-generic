namespace Generic.Domain.Helper;

public class KeyValueGeneric<T>
{
    public int Key { get; set; }
    public T Value { get; set; }

    public override string ToString()
    {
        return $"ID = {Key}, Value = {Value}";
    }
}
