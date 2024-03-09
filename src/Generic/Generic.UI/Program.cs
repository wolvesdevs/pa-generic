using Generic.Domain.Entities;

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

public interface IWrite<in T>
{
    void Add(T entity);
}

public class Entities<T> : IRead<T>, IWrite<T>
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

    private static void Read(IRead<IEntity> read)
    {
        var val = read.GetData(0);
    }

    public static void UseB()
    {
        Entities<IEntity> list = new();
        WriteProduct(list);
    }

    private static void WriteProduct(IWrite<Product> write)
    {
        write.Add(new Product(2, "B"));
    }
}

public interface IEntity { }
public class Product(int id, string name) : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public static class ActionUse
{
    private static void Use()
    {
        Action<object> oo = CallbackObj;
        oo.Invoke(DateTime.Now);

        Action<string> ss = CallbackString;
        ss.Invoke("Hello");

        //Action<object> os = CallbackString;
        //os.Invoke(DateTime.Now);

        Action<string> so = CallbackObj;
        so.Invoke("Hello");
    }

    private static void CallbackObj(object o) { }
    private static void CallbackString(string s) { }
 }
