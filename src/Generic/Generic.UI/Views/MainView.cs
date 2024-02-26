using Generic.Domain.Helper;

namespace Generic.UI.Views;

public partial class MainView : Form
{
    public MainView()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void MainView_Load(object sender, EventArgs e)
    {
        KeyValue k1 = new();
        k1.Key = 1;
        k1.Value = 2;
    }
}
