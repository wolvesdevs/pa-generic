namespace Generic.Domain.Exceptions;

public class CsvException : Exception
{
    public CsvException(string message) : base(message)
    {
    }
}
