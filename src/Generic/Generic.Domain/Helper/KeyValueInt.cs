namespace Generic.Domain.Helper;

public class KeyValueInt
{
    public int Key { get; set; }
    public int Value { get; set; }

    public override string ToString()
    {
        return $"ID = {Key}, Value = {Value}";
    }
}
