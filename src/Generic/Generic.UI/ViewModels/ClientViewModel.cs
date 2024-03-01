using Generic.Domain.Helper;

namespace Generic.UI.ViewModels;

public class ClientViewModel
{
    public static void Use()
    {
        ClassG<ProductEntity> classG = new();
        var p = classG.FindData(1);
    }
}
