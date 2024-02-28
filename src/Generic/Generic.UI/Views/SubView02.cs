﻿using Generic.Domain.Helper;

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

    }
}