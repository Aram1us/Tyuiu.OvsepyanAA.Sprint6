using Tyuiu.OvsepyanAA.Sprint6.Task5.V24.Lib;

namespace Tyuiu.OvsepyanAA.Sprint6.Task5.V24
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        private static readonly string path = @"D:\source\repos\Tyuiu.OvsepyanAA.Sprint6\Tyuiu.OvsepyanAA.Sprint6.Task5.V24\bin\Debug\net8.0-windows\InPutDataFileTask5V24.txt";
        DataService service = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_OAA_Click(object sender, EventArgs e)
        {
            dataGridViewRes_OAA.Rows.Clear();
            chartRes_OAA.Series[0].Points.Clear();

            dataGridViewRes_OAA.ColumnCount = 2;
            dataGridViewRes_OAA.Columns[0].Width = 20;
            dataGridViewRes_OAA.Columns[1].Width = 50;

            chartRes_OAA.ChartAreas[0].AxisX.Title = "Ось X";
            chartRes_OAA.ChartAreas[0].AxisY.Title = "Ось Y";

            double[] serviceArray = service.LoadFromDataFile(path);
            for (int i = 0; i < serviceArray.Length; i++)
            {
                dataGridViewRes_OAA.Rows.Add(i + 1, serviceArray[i]);
                chartRes_OAA.Series[0].Points.AddXY(i, serviceArray[i]);
            }
        }

        private void buttonSave_OAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_OAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-24-1 Овсепян Арам Андраникович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
