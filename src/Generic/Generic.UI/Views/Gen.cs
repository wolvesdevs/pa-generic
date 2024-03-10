using Generic.Domain.Entities;
using Generic.Domain.Exceptions;
using Generic.Infrastructure.Csv;
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
        ProductCsv productCsv = new();
        dataGridView1.DataSource = productCsv.GetAll();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        StockCsv stockCsv = new();
        dataGridView1.DataSource = stockCsv.GetAll();
    }

    //private void button1_Click(object sender, EventArgs e)
    //{
    //    //ProductCsv productCsv = new();
    //    //dataGridView1.DataSource = productCsv.GetAll();

    //    //ProductCsv2 productCsv = new();
    //    //dataGridView1.DataSource = productCsv.GetAll();
    //}

    //private void button2_Click(object sender, EventArgs e)
    //{
    //    //StockCsv stockCsv = new();
    //    //dataGridView1.DataSource = stockCsv.GetAll();

    //    //StockCsv2 stockCsv = new();
    //    //dataGridView1.DataSource = stockCsv.GetAll();
    //}
}
