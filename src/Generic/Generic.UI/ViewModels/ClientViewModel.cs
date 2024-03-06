using Generic.Domain.Entities;
using Generic.Domain.Helper;
using Generic.Domain.Repositories;

namespace Generic.UI.ViewModels;

public class ClientViewModel
{
    public static void Use()
    {
        //ClassG<ProductEntity> classG = new();
        //var p = classG.FindData(1);

        //ClassG<StockEntity> classG2 = new();

        //ClassH<int> k1 = new();
        //ClassH<Point> k2 = new();
        //ClassH<string> k3 = new();

        //ClassH<int?> k11 = new();
        //ClassH<Point?> k12 = new();
        //ClassH<string?> k13 = new();

        //ClassK<ProductEntity, Form> k4 = new();

        //var l1 = new ClassL<int>().GetData();
        //var l2 = new ClassL<bool>().GetData();
        //var l3 = new ClassL<string>().GetData();

        //Msub msub = new();
        //MSub2<string, int> msub2 = new();

        ClassS<int> classS = new();
        classS.Run<int>(1);
        classS.Run<string>("ABC");

        // 型推論
        classS.Run(10);
        classS.Run("ABC");

    }

    public static void Save<T>(T entity) where T : class, IEntity, IDisposable, new()
    {

    }

    public static void GetData<T>(T[] entities)
    {
        foreach (var entity in entities)
        {

        }
    }

    public static void GetData<T>(IEnumerable<T> entities)
    {
        foreach (var entity in entities)
        {

        }
    }
}
