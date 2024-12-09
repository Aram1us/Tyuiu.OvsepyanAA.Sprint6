using Tyuiu.OvsepyanAA.Sprint6.Task1.V30.Lib;

namespace Tyuiu.OvsepyanAA.Sprint6.Task1.V30
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
                int startValue = Convert.ToInt32(textBoxX.Text);
                int stopValue = Convert.ToInt32(textBoxY.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxRes.Text = "";
                textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,7:d}   |  {1,9:f2}   |", startValue, valueArray[i]);
                    textBoxRes.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void buttonHelp_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-24-1 Овсепян Арам Андраникович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

        
   

