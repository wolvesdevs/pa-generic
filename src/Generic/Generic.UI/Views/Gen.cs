using Generic.Domain.Entities;
using Generic.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic.UI.Views;
public partial class Gen : Form
{
    public Gen()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var lines = File.ReadAllLines("Product.csv");
        bool isFirst = true;
        List<ProductEntity> entities = new();

        foreach (var line in lines)
        {
            if (isFirst)
            {
                isFirst = false;
                continue;
            }

            var items = line.Split(',');
            if (items.Length != 3)
            {
                throw new CsvException();
            }

            ProductEntity product = new(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));

            entities.Add(product);
        }

        dataGridView1.DataSource = entities;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var lines = File.ReadAllLines("Stock.csv");
        bool isFirst = true;
        List<StockEntity> entities = new();

        foreach (var line in lines)
        {
            if (isFirst)
            {
                isFirst = false;
                continue;
            }

            var items = line.Split(',');
            if (items.Length != 2)
            {
                throw new CsvException();
            }

            StockEntity product = new(Convert.ToInt32(items[0]), Convert.ToInt32(items[1]));

            entities.Add(product);
        }

        dataGridView1.DataSource = entities;
    }
}
