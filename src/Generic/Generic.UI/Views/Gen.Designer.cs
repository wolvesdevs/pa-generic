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
        button1 = new Button();
        dataGridView1 = new DataGridView();
        button2 = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new Font("Yu Gothic UI", 16F);
        button1.Location = new Point(12, 12);
        button1.Name = "button1";
        button1.Size = new Size(259, 72);
        button1.TabIndex = 0;
        button1.Text = "product csv";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 104);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(698, 314);
        dataGridView1.TabIndex = 1;
        // 
        // button2
        // 
        button2.Font = new Font("Yu Gothic UI", 16F);
        button2.Location = new Point(304, 12);
        button2.Name = "button2";
        button2.Size = new Size(259, 72);
        button2.TabIndex = 2;
        button2.Text = "stock csv";
        button2.UseVisualStyleBackColor = true;
        // 
        // Gen
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button2);
        Controls.Add(dataGridView1);
        Controls.Add(button1);
        Name = "Gen";
        Text = "Gen";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
    private DataGridView dataGridView1;
    private Button button2;
}