namespace Tyuiu.OvsepyanAA.Sprint6.Task5.V24
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
            groupBoxTask_OAA = new GroupBox();
            textBoxTask_OAA = new TextBox();
            groupBoxRes = new GroupBox();
            dataGridView1 = new DataGridView();
            buttonDone_OAA = new Button();
            buttonSave_OAA = new Button();
            buttonHelp_OAA = new Button();
            chartRes_OAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxRes_OAA = new GroupBox();
            dataGridViewRes_OAA = new DataGridView();
            groupBoxTask_OAA.SuspendLayout();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRes_OAA).BeginInit();
            groupBoxRes_OAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_OAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_OAA
            // 
            groupBoxTask_OAA.Controls.Add(textBoxTask_OAA);
            groupBoxTask_OAA.Controls.Add(groupBoxRes);
            groupBoxTask_OAA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTask_OAA.Location = new Point(12, 12);
            groupBoxTask_OAA.Name = "groupBoxTask_OAA";
            groupBoxTask_OAA.Size = new Size(666, 133);
            groupBoxTask_OAA.TabIndex = 1;
            groupBoxTask_OAA.TabStop = false;
            groupBoxTask_OAA.Text = "Условие";
            // 
            // textBoxTask_OAA
            // 
            textBoxTask_OAA.Location = new Point(6, 24);
            textBoxTask_OAA.Multiline = true;
            textBoxTask_OAA.Name = "textBoxTask_OAA";
            textBoxTask_OAA.Size = new Size(654, 103);
            textBoxTask_OAA.TabIndex = 0;
            textBoxTask_OAA.Text = "Прочитать данные из файла InPutFileTask5V24.txt. Вывести в dataGridView.Дан список из чисел. Вывести все элементы, равные 0.";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(dataGridView1);
            groupBoxRes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxRes.Location = new Point(6, 133);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(271, 422);
            groupBoxRes.TabIndex = 2;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(259, 392);
            dataGridView1.TabIndex = 0;
            // 
            // buttonDone_OAA
            // 
            buttonDone_OAA.Location = new Point(714, 46);
            buttonDone_OAA.Name = "buttonDone_OAA";
            buttonDone_OAA.Size = new Size(100, 57);
            buttonDone_OAA.TabIndex = 5;
            buttonDone_OAA.Text = "Выполнить";
            buttonDone_OAA.UseVisualStyleBackColor = true;
            buttonDone_OAA.Click += buttonDone_OAA_Click;
            // 
            // buttonSave_OAA
            // 
            buttonSave_OAA.Location = new Point(878, 46);
            buttonSave_OAA.Name = "buttonSave_OAA";
            buttonSave_OAA.Size = new Size(96, 57);
            buttonSave_OAA.TabIndex = 6;
            buttonSave_OAA.Text = "Cохранить";
            buttonSave_OAA.UseVisualStyleBackColor = true;
            buttonSave_OAA.Click += buttonSave_OAA_Click;
            // 
            // buttonHelp_OAA
            // 
            buttonHelp_OAA.Location = new Point(1037, 46);
            buttonHelp_OAA.Name = "buttonHelp_OAA";
            buttonHelp_OAA.Size = new Size(112, 57);
            buttonHelp_OAA.TabIndex = 7;
            buttonHelp_OAA.Text = "Справка";
            buttonHelp_OAA.UseVisualStyleBackColor = true;
            buttonHelp_OAA.Click += buttonHelp_OAA_Click;
            // 
            // chartRes_OAA
            // 
            chartArea1.Name = "ChartArea1";
            chartRes_OAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRes_OAA.Legends.Add(legend1);
            chartRes_OAA.Location = new Point(471, 169);
            chartRes_OAA.Name = "chartRes_OAA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_OAA.Series.Add(series1);
            chartRes_OAA.Size = new Size(698, 392);
            chartRes_OAA.TabIndex = 1;
            chartRes_OAA.Text = "chart1";
            // 
            // groupBoxRes_OAA
            // 
            groupBoxRes_OAA.Controls.Add(dataGridViewRes_OAA);
            groupBoxRes_OAA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxRes_OAA.Location = new Point(24, 150);
            groupBoxRes_OAA.Name = "groupBoxRes_OAA";
            groupBoxRes_OAA.Size = new Size(390, 417);
            groupBoxRes_OAA.TabIndex = 8;
            groupBoxRes_OAA.TabStop = false;
            groupBoxRes_OAA.Text = "Результат";
            // 
            // dataGridViewRes_OAA
            // 
            dataGridViewRes_OAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_OAA.Location = new Point(3, 21);
            dataGridViewRes_OAA.Name = "dataGridViewRes_OAA";
            dataGridViewRes_OAA.Size = new Size(381, 390);
            dataGridViewRes_OAA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 579);
            Controls.Add(groupBoxRes_OAA);
            Controls.Add(chartRes_OAA);
            Controls.Add(buttonHelp_OAA);
            Controls.Add(buttonSave_OAA);
            Controls.Add(buttonDone_OAA);
            Controls.Add(groupBoxTask_OAA);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "FormMain";
            Text = "Cпринт 6 | Таск 5 | Вариант 24 | Овсепян А.А.";
            groupBoxTask_OAA.ResumeLayout(false);
            groupBoxTask_OAA.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRes_OAA).EndInit();
            groupBoxRes_OAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_OAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_OAA;
        private TextBox textBoxTask_OAA;
        private GroupBox groupBoxRes;
        private Button buttonDone_OAA;
        private Button buttonSave_OAA;
        private Button buttonHelp_OAA;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_OAA;
        private GroupBox groupBoxRes_OAA;
        private DataGridView dataGridViewRes_OAA;
    }
}
