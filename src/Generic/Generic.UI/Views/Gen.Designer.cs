namespace Generic.UI.Views;

partial class Gen
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ProductCsv1Button = new Button();
        dataGridView1 = new DataGridView();
        StockCsv1Button = new Button();
        ProductCsv2Button = new Button();
        StockCsv2Button = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // ProductCsv1Button
        // 
        ProductCsv1Button.Font = new Font("Yu Gothic UI", 16F);
        ProductCsv1Button.Location = new Point(12, 12);
        ProductCsv1Button.Name = "ProductCsv1Button";
        ProductCsv1Button.Size = new Size(259, 72);
        ProductCsv1Button.TabIndex = 0;
        ProductCsv1Button.Text = "product csv1";
        ProductCsv1Button.UseVisualStyleBackColor = true;
        ProductCsv1Button.Click += ProductCsv1Button_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 188);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(551, 314);
        dataGridView1.TabIndex = 99;
        // 
        // StockCsv1Button
        // 
        StockCsv1Button.Font = new Font("Yu Gothic UI", 16F);
        StockCsv1Button.Location = new Point(304, 12);
        StockCsv1Button.Name = "StockCsv1Button";
        StockCsv1Button.Size = new Size(259, 72);
        StockCsv1Button.TabIndex = 1;
        StockCsv1Button.Text = "stock csv1";
        StockCsv1Button.UseVisualStyleBackColor = true;
        StockCsv1Button.Click += StockCsv1Button_Click;
        // 
        // ProductCsv2Button
        // 
        ProductCsv2Button.Font = new Font("Yu Gothic UI", 16F);
        ProductCsv2Button.Location = new Point(12, 90);
        ProductCsv2Button.Name = "ProductCsv2Button";
        ProductCsv2Button.Size = new Size(259, 72);
        ProductCsv2Button.TabIndex = 2;
        ProductCsv2Button.Text = "product csv2";
        ProductCsv2Button.UseVisualStyleBackColor = true;
        ProductCsv2Button.Click += this.ProductCsv2Button_Click;
        // 
        // StockCsv2Button
        // 
        StockCsv2Button.Font = new Font("Yu Gothic UI", 16F);
        StockCsv2Button.Location = new Point(304, 90);
        StockCsv2Button.Name = "StockCsv2Button";
        StockCsv2Button.Size = new Size(259, 72);
        StockCsv2Button.TabIndex = 3;
        StockCsv2Button.Text = "stock csv2";
        StockCsv2Button.UseVisualStyleBackColor = true;
        StockCsv2Button.Click += StockCsv2Button_Click;
        // 
        // Gen
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(574, 513);
        Controls.Add(StockCsv2Button);
        Controls.Add(ProductCsv2Button);
        Controls.Add(StockCsv1Button);
        Controls.Add(dataGridView1);
        Controls.Add(ProductCsv1Button);
        Name = "Gen";
        Text = "Gen";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button ProductCsv1Button;
    private DataGridView dataGridView1;
    private Button StockCsv1Button;
    private Button ProductCsv2Button;
    private Button StockCsv2Button;
}
