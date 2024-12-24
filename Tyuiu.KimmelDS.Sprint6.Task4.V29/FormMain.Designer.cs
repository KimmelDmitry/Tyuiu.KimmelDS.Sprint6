namespace Tyuiu.KimmelDS.Sprint6.Task4.V29;

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
        pictureBox = new PictureBox();
        groupBoxPrint = new GroupBox();
        label3 = new Label();
        textBoxResult = new TextBox();
        groupBoxInput = new GroupBox();
        textBoxStop = new TextBox();
        textBoxStart = new TextBox();
        label2 = new Label();
        label1 = new Label();
        buttonRun = new Button();
        buttonHelp = new Button();
        buttonSave = new Button();
        groupBoxInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
        groupBoxPrint.SuspendLayout();
        groupBoxInput.SuspendLayout();
        SuspendLayout();
        // 
        // groupBoxInfo
        // 
        groupBoxInfo.Controls.Add(pictureBox);
        groupBoxInfo.Font = new Font("Segoe UI", 12F);
        groupBoxInfo.Location = new Point(12, 12);
        groupBoxInfo.Name = "groupBoxInfo";
        groupBoxInfo.Size = new Size(435, 282);
        groupBoxInfo.TabIndex = 0;
        groupBoxInfo.TabStop = false;
        groupBoxInfo.Tag = "";
        groupBoxInfo.Text = "Условие";
        groupBoxInfo.UseCompatibleTextRendering = true;
        // 
        // pictureBox
        // 
        pictureBox.Location = new Point(0, 31);
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new Size(435, 160);
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox.TabIndex = 0;
        pictureBox.TabStop = false;
        pictureBox.Click += pictureBox1_Click;
        // 
        // groupBoxPrint
        // 
        groupBoxPrint.Controls.Add(label3);
        groupBoxPrint.Controls.Add(textBoxResult);
        groupBoxPrint.Font = new Font("Segoe UI", 12F);
        groupBoxPrint.Location = new Point(453, 12);
        groupBoxPrint.Name = "groupBoxPrint";
        groupBoxPrint.Size = new Size(299, 397);
        groupBoxPrint.TabIndex = 1;
        groupBoxPrint.TabStop = false;
        groupBoxPrint.Text = "Вывод данных";
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
        // textBoxResult
        // 
        textBoxResult.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBoxResult.Location = new Point(6, 53);
        textBoxResult.Multiline = true;
        textBoxResult.Name = "textBoxResult";
        textBoxResult.ReadOnly = true;
        textBoxResult.ScrollBars = ScrollBars.Vertical;
        textBoxResult.Size = new Size(287, 338);
        textBoxResult.TabIndex = 0;
        // 
        // groupBoxInput
        // 
        groupBoxInput.Controls.Add(textBoxStop);
        groupBoxInput.Controls.Add(textBoxStart);
        groupBoxInput.Controls.Add(label2);
        groupBoxInput.Controls.Add(label1);
        groupBoxInput.Font = new Font("Segoe UI", 12F);
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
        textBoxStop.Size = new Size(85, 29);
        textBoxStop.TabIndex = 3;
        textBoxStop.Text = "5";
        // 
        // textBoxStart
        // 
        textBoxStart.Location = new Point(6, 53);
        textBoxStart.Name = "textBoxStart";
        textBoxStart.Size = new Size(82, 29);
        textBoxStart.TabIndex = 2;
        textBoxStart.Text = "-5";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 10F);
        label2.Location = new Point(122, 31);
        label2.Name = "label2";
        label2.Size = new Size(85, 19);
        label2.TabIndex = 1;
        label2.Text = "Конец шага:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10F);
        label1.Location = new Point(6, 31);
        label1.Name = "label1";
        label1.Size = new Size(82, 19);
        label1.TabIndex = 0;
        label1.Text = "Старт шага:";
        // 
        // buttonRun
        // 
        buttonRun.BackColor = Color.FromArgb(0, 192, 0);
        buttonRun.Font = new Font("Segoe UI", 12F);
        buttonRun.Location = new Point(342, 353);
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
        buttonHelp.Location = new Point(255, 353);
        buttonHelp.Name = "buttonHelp";
        buttonHelp.Size = new Size(81, 56);
        buttonHelp.TabIndex = 4;
        buttonHelp.Text = "Справка";
        buttonHelp.UseVisualStyleBackColor = false;
        buttonHelp.Click += buttonHelp_Click;
        // 
        // buttonSave
        // 
        buttonSave.BackColor = Color.Yellow;
        buttonSave.Font = new Font("Segoe UI", 12F);
        buttonSave.Location = new Point(255, 300);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(192, 50);
        buttonSave.TabIndex = 5;
        buttonSave.Text = "Сохранить в файл";
        buttonSave.UseVisualStyleBackColor = false;
        buttonSave.Click += buttonSave_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(764, 421);
        Controls.Add(buttonSave);
        Controls.Add(buttonHelp);
        Controls.Add(buttonRun);
        Controls.Add(groupBoxInput);
        Controls.Add(groupBoxPrint);
        Controls.Add(groupBoxInfo);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Спринт 6 | Таск 4 | Вариант 12 | Молодчиков Е.Е.";
        groupBoxInfo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
        groupBoxPrint.ResumeLayout(false);
        groupBoxPrint.PerformLayout();
        groupBoxInput.ResumeLayout(false);
        groupBoxInput.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxInfo;
    private GroupBox groupBoxPrint;
    private GroupBox groupBoxInput;
    private PictureBox pictureBox;
    private TextBox textBoxResult;
    private Button buttonRun;
    private Button buttonHelp;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBoxStop;
    private TextBox textBoxStart;
    private Button buttonSave;
}
