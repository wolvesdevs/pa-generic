namespace Generic.Domain.Helper;

public class KeyValue
{
    public int Key { get; set; }
    public object? Value { get; set; }

    public override string ToString()
    {
        return $"ID = {Key}, Value = {Value}";
    }
}
