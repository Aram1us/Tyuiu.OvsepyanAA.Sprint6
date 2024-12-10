using Tyuiu.OvsepyanAA.Sprint6.Task2.V22.Lib;

namespace Tyuiu.OvsepyanAA.Sprint6.Task2.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);

                this.chartCos.Titles.Add("График функции cos(x)");
                this.chartCos.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartCos.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    dataGridViewTable.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i]));
                    this.chartCos.Series[0].Points.AddXY(start, valueArray[i]);
                    start++;

                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-24-1 Овсепян Арам Андраникович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }
    }


}