namespace cross;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridView1 = new DataGridView();
        comboBox1 = new ComboBox();
        btn_get = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(41, 92);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(690, 335);
        dataGridView1.TabIndex = 0;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(41, 30);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(121, 23);
        comboBox1.TabIndex = 1;
        // 
        // btn_get
        // 
        btn_get.Location = new Point(220, 30);
        btn_get.Name = "btn_get";
        btn_get.Size = new Size(75, 23);
        btn_get.TabIndex = 2;
        btn_get.Text = "Get Students";
        btn_get.UseVisualStyleBackColor = true;
        btn_get.Click += new EventHandler(btn_get_Click);
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btn_get);
        Controls.Add(comboBox1);
        Controls.Add(dataGridView1);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private ComboBox comboBox1;
    private Button btn_get;
}
