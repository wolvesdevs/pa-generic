namespace Generic.Domain.Helper;

public class Product(int id, string value)
{
    public int Id { get; set; } = id;
    public string Value { get; set; } = value;
}
