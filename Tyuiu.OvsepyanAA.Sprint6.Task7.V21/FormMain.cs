using Tyuiu.OvsepyanAA.Sprint6.Task7.V21.Lib;

namespace Tyuiu.OvsepyanAA.Sprint6.Task7.V21
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
            openFileDialogTask_OAA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_OAA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        private string openFilePath;
        private int rows;
        private int columns;


        public static int[,] LoadFromFileData(string filePath, int rows, int columns)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpen_OAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_OAA.ShowDialog();
            openFilePath = openFileDialogTask_OAA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewLn_OAA.ColumnCount = columns;
            dataGridViewLn_OAA.RowCount = rows;
            dataGridViewLn_OAA.ColumnCount = columns;
            dataGridViewLn_OAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewLn_OAA.Columns[i].Width = 25;
                dataGridViewLn_OAA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewLn_OAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_OAA.Enabled = true;
        }
   

        private void buttonDone_OAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_OAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_OAA.Enabled = true;
        }

        private void buttonSave_OAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_OAA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_OAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_OAA.ShowDialog();

            string path = saveFileDialogMatrix_OAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_OAA.RowCount;
            int columns = dataGridViewOut_OAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_OAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_OAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнил студент группы СМАРТб-24-1 Овсепян Арам Андраникович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
    
    

