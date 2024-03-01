using Generic.Domain.Entities;
using Generic.Domain.Helper;

namespace Generic.UI.ViewModels;

public class ClientViewModel
{
    public static void Use()
    {
        ClassG<ProductEntity> classG = new();
        var p = classG.FindData(1);

        //ClassG<StockEntity> classG2 = new();
    }
}
