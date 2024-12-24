using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KimmelDS.Sprint6.Task5.V2.Lib;

namespace Tyuiu.KimmelDS.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\Mollenq\source\repos\Tyuiu.MolodchikovEE.Sprint6\Tyuiu.MolodchikovEE.Sprint6.Task5.V10\bin\Debug\net8.0-windows\OutPutFileTask5.txt";

        private void buttonRunClick(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNums.ColumnCount = 2;
                dataGridViewNums.Columns[0].Width = 20;
                dataGridViewNums.Columns[1].Width = 50;

                
                List<double> numsMass = ds.LoadFromDataFile(path).ToList();

                for (int i = 0; i < numsMass.Count; i++)
                {
                    dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                }

            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåíðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 5 âûïîëíèë ñòóäåíò ãðóïïû ÈÈÏá-24-1 Ìîëîä÷èêîâ Åãîð Åâãåíüåâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonHelp_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Òàñê 5 âûïîëíèë ñòóäåíò ãðóïïû ÈÈÏá-24-1 Ìîëîä÷èêîâ Åãîð Åâãåíüåâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Ñáîé ïðè îòêðûòèå ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}