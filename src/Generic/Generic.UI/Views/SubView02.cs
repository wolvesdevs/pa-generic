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
        KeyValueA<int> keyValueA = new();
    }
}
