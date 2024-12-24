namespace Tyuiu.KimmelDS.Sprint6.Task5.V2;

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
        groupBoxInfo = new GroupBox();
        textBox1 = new TextBox();
        groupBoxPrint = new GroupBox();
        dataGridViewNums = new DataGridView();
        label3 = new Label();
        buttonRun = new Button();
        buttonHelp = new Button();
        buttonOpen = new Button();
        groupBoxInfo.SuspendLayout();
        groupBoxPrint.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
        SuspendLayout();
        // 
        // groupBoxInfo
        // 
        groupBoxInfo.Controls.Add(textBox1);
        groupBoxInfo.Font = new Font("Segoe UI", 12F);
        groupBoxInfo.Location = new Point(12, 12);
        groupBoxInfo.Name = "groupBoxInfo";
        groupBoxInfo.Size = new Size(255, 282);
        groupBoxInfo.TabIndex = 0;
        groupBoxInfo.TabStop = false;
        groupBoxInfo.Tag = "";
        groupBoxInfo.Text = "Условие";
        groupBoxInfo.UseWaitCursor = true;
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBox1.Location = new Point(6, 28);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.ScrollBars = ScrollBars.Vertical;
        textBox1.Size = new Size(243, 248);
        textBox1.TabIndex = 3;
        textBox1.Text = resources.GetString("textBox1.Text");
        textBox1.UseWaitCursor = true;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // groupBoxPrint
        // 
        groupBoxPrint.Controls.Add(dataGridViewNums);
        groupBoxPrint.Controls.Add(label3);
        groupBoxPrint.Font = new Font("Segoe UI", 12F);
        groupBoxPrint.Location = new Point(273, 12);
        groupBoxPrint.Name = "groupBoxPrint";
        groupBoxPrint.Size = new Size(299, 397);
        groupBoxPrint.TabIndex = 1;
        groupBoxPrint.TabStop = false;
        groupBoxPrint.Text = "Вывод данных";
        // 
        // dataGridViewNums
        // 
        dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewNums.ColumnHeadersVisible = false;
        dataGridViewNums.Location = new Point(6, 53);
        dataGridViewNums.Name = "dataGridViewNums";
        dataGridViewNums.RowHeadersVisible = false;
        dataGridViewNums.Size = new Size(287, 338);
        dataGridViewNums.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 10F);
        label3.Location = new Point(6, 31);
        label3.Name = "label3";
        label3.Size = new Size(73, 19);
        label3.TabIndex = 2;
        label3.Text = "Результат:";
        // 
        // buttonRun
        // 
        buttonRun.BackColor = Color.FromArgb(0, 192, 0);
        buttonRun.Font = new Font("Segoe UI", 12F);
        buttonRun.Location = new Point(145, 353);
        buttonRun.Name = "buttonRun";
        buttonRun.Size = new Size(105, 56);
        buttonRun.TabIndex = 3;
        buttonRun.Text = "Выполнить";
        buttonRun.UseVisualStyleBackColor = false;
        buttonRun.Click += buttonRunClick;
        // 
        // buttonHelp
        // 
        buttonHelp.BackColor = Color.FromArgb(0, 192, 192);
        buttonHelp.Font = new Font("Segoe UI", 12F);
        buttonHelp.ForeColor = SystemColors.ControlText;
        buttonHelp.Location = new Point(24, 353);
        buttonHelp.Name = "buttonHelp";
        buttonHelp.Size = new Size(81, 56);
        buttonHelp.TabIndex = 4;
        buttonHelp.Text = "Справка";
        buttonHelp.UseVisualStyleBackColor = false;
        buttonHelp.Click += buttonHelp_Click;
        // 
        // buttonOpen
        // 
        buttonOpen.BackColor = Color.Yellow;
        buttonOpen.Font = new Font("Segoe UI", 12F);
        buttonOpen.Location = new Point(38, 300);
        buttonOpen.Name = "buttonOpen";
        buttonOpen.Size = new Size(192, 50);
        buttonOpen.TabIndex = 5;
        buttonOpen.Text = "Открыть файл";
        buttonOpen.UseVisualStyleBackColor = false;
        buttonOpen.Click += buttonOpen_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(586, 421);
        Controls.Add(buttonOpen);
        Controls.Add(buttonHelp);
        Controls.Add(buttonRun);
        Controls.Add(groupBoxPrint);
        Controls.Add(groupBoxInfo);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Спринт 6 | Таск 5 | Вариант 10 | Молодчиков Е.Е.";
        groupBoxInfo.ResumeLayout(false);
        groupBoxInfo.PerformLayout();
        groupBoxPrint.ResumeLayout(false);
        groupBoxPrint.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxInfo;
    private GroupBox groupBoxPrint;
    private Button buttonRun;
    private Button buttonHelp;
    private Label label3;
    private Button buttonOpen;
    private TextBox textBox1;
    private DataGridView dataGridViewNums;
}
