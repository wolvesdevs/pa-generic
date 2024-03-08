namespace Generic.UI.Views;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Gen());
    }
}

public interface IRead<out T>
{
    T GetData(int index);
}

public class Entities<T> : IRead<T>
{
    private List<T> _entities = new();

    public T GetData(int index)
    {
        return _entities[index];
    }

    public void Add(T entity)
    {
        _entities.Add(entity);
    }
}

public class Use
{
    public static void UseA()
    {
        Entities<Product> products = new();
        products.Add(new Product(1, "AAA"));
        Read(products);
    }

    private static void Read(IRead<IEntity> entities)
    {
        var val = entities.GetData(0);
    }
}

public interface IEntity { }
public class Product(int id, string name) : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}
