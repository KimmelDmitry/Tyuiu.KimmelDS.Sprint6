namespace Tyuiu.KimmelDS.Sprint6.Task3.V20;

partial class FormMain
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        groupBox1 = new GroupBox();
        label1 = new Label();
        groupBox2 = new GroupBox();
        dataGridViewMatrix = new DataGridView();
        label2 = new Label();
        buttonResult = new Button();
        buttonHelp = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 16);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(369, 393);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Условие";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 32);
        label1.Name = "label1";
        label1.Size = new Size(349, 180);
        label1.TabIndex = 0;
        label1.Text = resources.GetString("label1.Text");
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dataGridViewMatrix);
        groupBox2.Controls.Add(label2);
        groupBox2.Location = new Point(387, 16);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(417, 340);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Ввывод данных";
        // 
        // dataGridViewMatrix
        // 
        dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewMatrix.ColumnHeadersVisible = false;
        dataGridViewMatrix.Location = new Point(6, 37);
        dataGridViewMatrix.Name = "dataGridViewMatrix";
        dataGridViewMatrix.ReadOnly = true;
        dataGridViewMatrix.RowHeadersVisible = false;
        dataGridViewMatrix.RowHeadersWidth = 50;
        dataGridViewMatrix.Size = new Size(405, 297);
        dataGridViewMatrix.TabIndex = 4;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 19);
        label2.Name = "label2";
        label2.Size = new Size(63, 15);
        label2.TabIndex = 0;
        label2.Text = "Результат:";
        // 
        // buttonResult
        // 
        buttonResult.FlatStyle = FlatStyle.System;
        buttonResult.Location = new Point(483, 362);
        buttonResult.Margin = new Padding(3, 3, 10, 3);
        buttonResult.Name = "buttonResult";
        buttonResult.Padding = new Padding(10, 0, 0, 0);
        buttonResult.Size = new Size(321, 47);
        buttonResult.TabIndex = 2;
        buttonResult.Text = "Выполнить";
        buttonResult.UseVisualStyleBackColor = true;
        buttonResult.Click += buttonResult_Click;
        // 
        // buttonHelp
        // 
        buttonHelp.Location = new Point(387, 362);
        buttonHelp.Name = "buttonHelp";
        buttonHelp.Size = new Size(90, 47);
        buttonHelp.TabIndex = 3;
        buttonHelp.Text = "?";
        buttonHelp.UseVisualStyleBackColor = true;
        buttonHelp.Click += buttonHelp_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(816, 421);
        Controls.Add(buttonHelp);
        Controls.Add(buttonResult);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Спринт 6 | Таск 3 | Вариант 27 | Молодчиков Е.Е.";
        Load += FormMain_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label1;
    private GroupBox groupBox2;
    private DataGridView dataGridViewMatrix;
    private Label label2;
    private Button buttonResult;
    private Button buttonHelp;
}
