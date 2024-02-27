using Generic.Domain.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic.UI.Views;
public partial class SubView : Form
{
    public SubView()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // 代表的なジェネリッククラス
        // List<T>
        // Dictionary<TKey, TValue>
        // SortedList<TKey, TValue>
        // Queue<T>
        // Stack<T>

        // List<T>
        List<int> ints = [1, 2];
        List<string> strings = ["a", "b"];
        List<Product> products = [new Product(1, "a"), new Product(2, "b")];
        var pA = products[1];
        var pB = products.Where(p => p.Id == 2).FirstOrDefault();

        Debug.WriteLine($"<pA>Id = {pA.Id}, Value = {pA.Value}");
        Debug.WriteLine($"<pB>Id = {pB.Id}, Value = {pB.Value}");

        // Dictionary<TKey, TValue>
        Dictionary<int, string> dic = new()
        {
            {1, "a"},
            {3, "b"},
        };
        var dicA = dic[3];

        Debug.WriteLine($"dicA[3] = {dicA}");

        // SortedList<TKey, TValue>
        SortedList<int, string> sList = new()
        {
            {1, "a"},
            {4, "d"},
            {2, "b"},
            {3, "c"},
        };

        foreach (var item in sList)
        {
            Debug.WriteLine($"<sList>Key = {item.Key}, Value = {item.Value}");
        }

        // Queue<T>
        Queue<Product> q = new();
        q.Enqueue(new Product(4, "d"));
        q.Enqueue(new Product(2, "b"));
        q.Enqueue(new Product(1, "a"));
        q.Enqueue(new Product(3, "c"));

        foreach (var item in q)
        {
            Debug.WriteLine($"<q>Id = {item.Id}, Value = {item.Value}");
        }

        // Stack<T>
        Stack<Product> s = new();
        s.Push(new Product(4, "d"));
        s.Push(new Product(2, "b"));
        s.Push(new Product(1, "a"));
        s.Push(new Product(3, "c"));

        foreach (var item in s)
        {
            Debug.WriteLine($"<s>Id = {item.Id}, Value = {item.Value}");
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        ArrayList a = new();
        a.Add(1);
        a.Add("a");
        a.Add(new Product(1, "a"));
        var o1 = a[0];
        
        Stack s = new();
        s.Push(1);
        s.Push("a");
        s.Push(new Product(1, "a"));
        var o2 = s.Pop();
    }
}
