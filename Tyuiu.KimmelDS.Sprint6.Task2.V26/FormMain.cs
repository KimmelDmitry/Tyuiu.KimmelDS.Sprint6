using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KimmelDS.Sprint6.Task2.V26.Lib;

namespace Tyuiu.KimmelDS.Sprint6.Task2.V26
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

                //this.chartFunction.Titles.Add("Ãðàôèê ôóíêöèè sin(x)");

                //this.chartFunction.ChartAreas[0].AxisX.Title = "Îñü X";
                //this.chartFunction.ChartAreas[0].AxisY.Title = "Îñü Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    //this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
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
            MessageBox.Show("Òàñê 2 âûïîëíèë ñòóäåíò ãðóïïû ÈÈÏá-24-1 Ìîëîä÷èêîâ Åãîð Åâãåíüåâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
}