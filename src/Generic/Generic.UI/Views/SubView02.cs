using Generic.Domain.Entities;
using Generic.Domain.Helper;
using Generic.UI.ViewModels;

namespace Generic.UI.Views;
public partial class SubView02 : Form
{
    public SubView02()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // 値型制約
        KeyValueA<int> keyValueA = new();

        // 参照型制約
        KeyValueB<string> keyValueB1 = new();
        KeyValueB<Product> keyValueB2 = new();

        KeyValueC<string> c1 = new();
        c1.Run();

        KeyValueC<int> c2 = new();
        c2.Run();

        // C#7.3 以降で使えるようになった型制約
        //E04<Action, Action<int>, DayOfWeek> e04 = new();
        //e04.Run(10, DayOfWeek.Monday);

        // 副制約（2次制約）_IEntity
        ClassF<ProductEntity> classF = new();

        ClientViewModel.Use();
        ClientViewModel.Save(new ProductEntity());
        //ClientViewModel.Save(new StockEntity(1, "abc"));


    }
}
