namespace Tyuiu.KimmelDS.Sprint6.Task2.V26;

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
        groupBoxInfo = new GroupBox();
        pictureBox1 = new PictureBox();
        groupBoxPrint = new GroupBox();
        label3 = new Label();
        groupBoxInput = new GroupBox();
        textBoxStop = new TextBox();
        textBoxStart = new TextBox();
        label2 = new Label();
        label1 = new Label();
        buttonRun = new Button();
        buttonHelp = new Button();
        dataGridViewFunction = new DataGridView();
        Column1 = new DataGridViewTextBoxColumn();
        Column2 = new DataGridViewTextBoxColumn();
        groupBoxInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        groupBoxPrint.SuspendLayout();
        groupBoxInput.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
        SuspendLayout();
        // 
        // groupBoxInfo
        // 
        groupBoxInfo.Controls.Add(pictureBox1);
        groupBoxInfo.Location = new Point(12, 12);
        groupBoxInfo.Name = "groupBoxInfo";
        groupBoxInfo.Size = new Size(435, 282);
        groupBoxInfo.TabIndex = 0;
        groupBoxInfo.TabStop = false;
        groupBoxInfo.Tag = "";
        groupBoxInfo.Text = "Условие";
        groupBoxInfo.UseCompatibleTextRendering = true;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.formula3;
        pictureBox1.Location = new Point(6, 22);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(423, 162);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // groupBoxPrint
        // 
        groupBoxPrint.Controls.Add(dataGridViewFunction);
        groupBoxPrint.Controls.Add(label3);
        groupBoxPrint.Location = new Point(453, 12);
        groupBoxPrint.Name = "groupBoxPrint";
        groupBoxPrint.Size = new Size(617, 397);
        groupBoxPrint.TabIndex = 1;
        groupBoxPrint.TabStop = false;
        groupBoxPrint.Text = "Вывод данных";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(6, 31);
        label3.Name = "label3";
        label3.Size = new Size(63, 15);
        label3.TabIndex = 2;
        label3.Text = "Результат:";
        // 
        // groupBoxInput
        // 
        groupBoxInput.Controls.Add(textBoxStop);
        groupBoxInput.Controls.Add(textBoxStart);
        groupBoxInput.Controls.Add(label2);
        groupBoxInput.Controls.Add(label1);
        groupBoxInput.Location = new Point(12, 300);
        groupBoxInput.Name = "groupBoxInput";
        groupBoxInput.Size = new Size(237, 109);
        groupBoxInput.TabIndex = 2;
        groupBoxInput.TabStop = false;
        groupBoxInput.Text = "Ввод данных";
        groupBoxInput.Enter += groupBox3_Enter;
        // 
        // textBoxStop
        // 
        textBoxStop.Location = new Point(122, 53);
        textBoxStop.Name = "textBoxStop";
        textBoxStop.Size = new Size(85, 23);
        textBoxStop.TabIndex = 3;
        textBoxStop.Text = "5";
        // 
        // textBoxStart
        // 
        textBoxStart.Location = new Point(6, 53);
        textBoxStart.Name = "textBoxStart";
        textBoxStart.Size = new Size(82, 23);
        textBoxStart.TabIndex = 2;
        textBoxStart.Text = "-5";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(122, 31);
        label2.Name = "label2";
        label2.Size = new Size(75, 15);
        label2.TabIndex = 1;
        label2.Text = "Конец шага:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 31);
        label1.Name = "label1";
        label1.Size = new Size(72, 15);
        label1.TabIndex = 0;
        label1.Text = "Старт шага:";
        // 
        // buttonRun
        // 
        buttonRun.BackColor = Color.FromArgb(0, 192, 0);
        buttonRun.Location = new Point(342, 301);
        buttonRun.Name = "buttonRun";
        buttonRun.Size = new Size(105, 108);
        buttonRun.TabIndex = 3;
        buttonRun.Text = "Выполнить";
        buttonRun.UseVisualStyleBackColor = false;
        buttonRun.Click += buttonRunClick;
        // 
        // buttonHelp
        // 
        buttonHelp.BackColor = Color.FromArgb(0, 192, 192);
        buttonHelp.ForeColor = SystemColors.ControlText;
        buttonHelp.Location = new Point(255, 301);
        buttonHelp.Name = "buttonHelp";
        buttonHelp.Size = new Size(81, 108);
        buttonHelp.TabIndex = 4;
        buttonHelp.Text = "Справка";
        buttonHelp.UseVisualStyleBackColor = false;
        buttonHelp.Click += buttonHelp_Click;
        // 
        // dataGridViewFunction
        // 
        dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
        dataGridViewFunction.Location = new Point(6, 49);
        dataGridViewFunction.Name = "dataGridViewFunction";
        dataGridViewFunction.RowHeadersVisible = false;
        dataGridViewFunction.Size = new Size(134, 342);
        dataGridViewFunction.TabIndex = 3;
        // 
        // Column1
        // 
        Column1.HeaderText = "X";
        Column1.Name = "Column1";
        Column1.ReadOnly = true;
        Column1.Width = 50;
        // 
        // Column2
        // 
        Column2.HeaderText = "f(X)";
        Column2.Name = "Column2";
        Column2.ReadOnly = true;
        Column2.Width = 50;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1082, 421);
        Controls.Add(buttonHelp);
        Controls.Add(buttonRun);
        Controls.Add(groupBoxInput);
        Controls.Add(groupBoxPrint);
        Controls.Add(groupBoxInfo);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Спринт 6 | Таск 2 | Вариант 4 | Молодчиков Е.Е.";
        groupBoxInfo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        groupBoxPrint.ResumeLayout(false);
        groupBoxPrint.PerformLayout();
        groupBoxInput.ResumeLayout(false);
        groupBoxInput.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxInfo;
    private GroupBox groupBoxPrint;
    private GroupBox groupBoxInput;
    private Button buttonRun;
    private Button buttonHelp;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBoxStop;
    private TextBox textBoxStart;
    private PictureBox pictureBox1;
    private DataGridView dataGridViewFunction;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
}
