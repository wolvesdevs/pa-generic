namespace Generic.Domain.Helper;

public class KeyValueString
{
    public int Key { get; set; }
    public string? Value { get; set; }

    public override string ToString()
    {
        return $"ID = {Key}, Value = {Value}";
    }
}
