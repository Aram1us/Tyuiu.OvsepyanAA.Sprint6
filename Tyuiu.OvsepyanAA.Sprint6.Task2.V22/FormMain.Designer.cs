namespace Tyuiu.OvsepyanAA.Sprint6.Task2.V22
{
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            fileSystemWatcher1 = new FileSystemWatcher();
            groupBoxCondition = new GroupBox();
            textBoxExample = new TextBox();
            groupBoxData = new GroupBox();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            groupBoxRes = new GroupBox();
            chartCos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewTable = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            buttonDone = new Button();
            buttonHelp = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            groupBoxCondition.SuspendLayout();
            groupBoxData.SuspendLayout();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(textBoxExample);
            groupBoxCondition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(634, 373);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // textBoxExample
            // 
            textBoxExample.Location = new Point(6, 21);
            textBoxExample.Multiline = true;
            textBoxExample.Name = "textBoxExample";
            textBoxExample.Size = new Size(622, 346);
            textBoxExample.TabIndex = 0;
            textBoxExample.Text = "Протабулировать функцию cos(x) на заданном диапозоне.\r\nРезультат вывести в DataGridView и построить график функции.\r\n";
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(textBoxStop);
            groupBoxData.Controls.Add(textBoxStart);
            groupBoxData.Location = new Point(18, 414);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(389, 76);
            groupBoxData.TabIndex = 1;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Ввод данных";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(237, 30);
            textBoxStop.Multiline = true;
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(146, 40);
            textBoxStop.TabIndex = 4;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 30);
            textBoxStart.Multiline = true;
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(150, 40);
            textBoxStart.TabIndex = 3;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(chartCos);
            groupBoxRes.Controls.Add(dataGridViewTable);
            groupBoxRes.Location = new Point(672, 12);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(526, 478);
            groupBoxRes.TabIndex = 2;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // chartCos
            // 
            chartArea1.Name = "ChartArea1";
            chartCos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCos.Legends.Add(legend1);
            chartCos.Location = new Point(134, 31);
            chartCos.Name = "chartCos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "SeriesCos";
            chartCos.Series.Add(series1);
            chartCos.Size = new Size(386, 360);
            chartCos.TabIndex = 5;
            chartCos.Text = "chart1";
            // 
            // dataGridViewTable
            // 
            dataGridViewTable.AllowUserToOrderColumns = true;
            dataGridViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable.Columns.AddRange(new DataGridViewColumn[] { X, Column1 });
            dataGridViewTable.Location = new Point(0, 31);
            dataGridViewTable.Name = "dataGridViewTable";
            dataGridViewTable.RowHeadersVisible = false;
            dataGridViewTable.Size = new Size(128, 441);
            dataGridViewTable.TabIndex = 5;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "F(X)";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone.Location = new Point(524, 416);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(122, 76);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.CornflowerBlue;
            buttonHelp.Location = new Point(422, 416);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(86, 76);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
          
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 502);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxData);
            Controls.Add(groupBoxCondition);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "FormMain";
            Text = "Cпринт 6 | Таск 2 | Вариант 22 | Овсепян А.А. ";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxData.ResumeLayout(false);
            groupBoxData.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartCos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private GroupBox groupBoxCondition;
        private TextBox textBoxExample;
        private GroupBox groupBoxData;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxRes;
        private DataGridView dataGridViewTable;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Column1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCos;
    }
}
