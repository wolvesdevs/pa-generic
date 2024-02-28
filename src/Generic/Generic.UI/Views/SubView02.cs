using Generic.Domain.Helper;

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
        KeyValueB<string> keyValueB = new();
        KeyValueB<Product> keyValueC = new();
    }
}
