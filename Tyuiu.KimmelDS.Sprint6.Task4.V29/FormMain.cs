using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KimmelDS.Sprint6.Task4.V29.Lib;

namespace Tyuiu.KimmelDS.Sprint6.Task4.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonRunClick(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+--------+" + Environment.NewLine);
                textBoxResult.AppendText("|     X    |  f(X)  |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+--------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |{1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult.AppendText("+----------+--------+" + Environment.NewLine);

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
            MessageBox.Show("Òàñê 4 âûïîëíèë ñòóäåíò ãðóïïû ÈÈÏá-24-1 Ìîëîä÷èêîâ Åãîð Åâãåíüåâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonHelp_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Òàñê 4 âûïîëíèë ñòóäåíò ãðóïïû ÈÈÏá-24-1 Ìîëîä÷èêîâ Åãîð Åâãåíüåâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show($"Ôàéë {path} óñïåøíî ñîõðàíåí! \n Îòêðûòü åãî â áëîêíîòå?", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ñáîé ïðè ñîõðàíåíèå ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}