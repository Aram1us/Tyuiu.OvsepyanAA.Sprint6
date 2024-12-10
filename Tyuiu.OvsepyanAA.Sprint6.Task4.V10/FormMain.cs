using Tyuiu.OvsepyanAA.Sprint6.Task4.V10.Lib;

namespace Tyuiu.OvsepyanAA.Sprint6.Task4.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_OAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы CМАРТб-24-1 Овсепян Арам Андраникович",
               "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_OAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
                File.WriteAllText(path, textBoxRes_OAA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \nОткрыть его в блокноте?",
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDone_OAA_Click(object sender, EventArgs e)
        {
            try 
        {
                int startStep = Convert.ToInt32(textBoxStart_OAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_OAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartCos_OAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartCos_OAA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRes_OAA.Text = "";

                chartCos_OAA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartCos_OAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxRes_OAA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
        }
         catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
    }


