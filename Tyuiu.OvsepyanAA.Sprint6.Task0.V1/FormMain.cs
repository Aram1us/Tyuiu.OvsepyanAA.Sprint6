using Tyuiu.OvsepyanAA.Sprint6.Task0.V1.Lib;

namespace Tyuiu.OvsepyanAA.Sprint6.Task0.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxAnswer.Text = Convert.ToString(ds.Calculate(3));
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы СМАРТб-24-1 Овсепян Арам Андраникович");
        }
    }
}
