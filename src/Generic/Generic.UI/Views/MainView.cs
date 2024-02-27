using Generic.Domain.Helper;
using System.Diagnostics;

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
        KeyValueInt k1 = new();
        k1.Key = 1;
        k1.Value = 2;
        Debug.WriteLine(k1.ToString());

        KeyValueString k2 = new();
        k2.Key = 2;
        k2.Value = "AAA";
        Debug.WriteLine(k2.ToString());

        KeyValueGeneric<int> o1 = new();
        o1.Key = 1;
        o1.Value = 2;

        KeyValueGeneric<string> o2 = new();
        o2.Key = 2;
        o2.Value = "BBB";
        
        KeyValueGeneric<int> o3 = new();
        o3.Key = 3;
        o3.Value = 33;

        int i1 = Convert.ToInt32(o1.Value);

        List<KeyValueGeneric<int>> keyValues = [o1, o3];

        foreach(var kv in keyValues)
        {
            Debug.WriteLine(kv.Value);
        }

        KeyValueGeneric<int> g1 = new();
        g1.Key = 1;
        g1.Value = 2;

        KeyValueGeneric<string> g2 = new();
        g2.Key = 2;
        g2.Value = "CCC";

        KeyValueGeneric<TextBox> g3 = new();
        g3.Key = 3;
        g3.Value = new TextBox();
    }
}
