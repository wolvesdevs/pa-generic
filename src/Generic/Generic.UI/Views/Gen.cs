using Generic.Domain;
using Generic.Domain.Entities;
using Generic.Domain.Exceptions;
using Generic.Infrastructure.Csv;
using Generic.Infrastructure.Csv.ForAbstractClass;
using Generic.Infrastructure.Csv.ForGenericMethod;
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

    /// <summary>
    /// ジェネリックの抽象クラスに置き換える
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="CsvException"></exception>
    private void ProductCsv1Button_Click(object sender, EventArgs e)
    {
        ProductCsv1 productCsv1 = new();
        dataGridView1.DataSource = productCsv1.GetAll();
    }

    /// <summary>
    /// ジェネリックの抽象クラスに置き換える
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="CsvException"></exception>
    private void StockCsv1Button_Click(object sender, EventArgs e)
    {
        StockCsv1 stockCsv1 = new();
        dataGridView1.DataSource = stockCsv1.GetAll();
    }

    /// <summary>
    /// ジェネリックのメソッドに置き換える
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ProductCsv2Button_Click(object sender, EventArgs e)
    {
        ProductCsv2 productCsv2 = new();
        dataGridView1.DataSource = productCsv2.GetAll();
    }

    /// <summary>
    /// ジェネリックのメソッドに置き換える
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StockCsv2Button_Click(object sender, EventArgs e)
    {
        StockCsv2 stockCsv2 = new();
        dataGridView1.DataSource = stockCsv2.GetAll();
    }

    //private void button1_Click(object sender, EventArgs e)
    //{
    //    // ジェネリックの抽象クラスに置き換える
    //    ProductCsv1 productCsv1 = new();
    //    dataGridView1.DataSource = productCsv1.GetAll();

    //    StockCsv1 stockCsv1 = new();
    //    dataGridView1.DataSource = stockCsv1.GetAll();

    //    // ジェネリックのメソッドに置き換える
    //    ProductCsv2 productCsv2 = new();
    //    dataGridView1.DataSource = productCsv2.GetAll();

    //    StockCsv2 stockCsv2 = new();
    //    dataGridView1.DataSource = stockCsv2.GetAll();
    //}
}
