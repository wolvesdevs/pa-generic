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

        KeyValue o1 = new();
        o1.Key = 1;
        o1.Value = 2;

        KeyValue o2 = new();
        o2.Key = 2;
        o2.Value = "BBB";

        //int i1 = Convert.ToInt32(o1.Value);

        //List<KeyValue> keyValues = [o1, o2];

        //foreach(KeyValue kv in keyValues)
        //{
        //    Debug.WriteLine(kv.Value);
        //}
    }
}
