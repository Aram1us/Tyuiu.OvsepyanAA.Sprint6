namespace Tyuiu.OvsepyanAA.Sprint6.Task4.V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_OAA = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxData_OAA = new GroupBox();
            textBoxStop_OAA = new TextBox();
            textBoxStart_OAA = new TextBox();
            groupBoxRes = new GroupBox();
            textBoxRes_OAA = new TextBox();
            chartCos_OAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonHelp_OAA = new Button();
            buttonDone_OAA = new Button();
            buttonSave_OAA = new Button();
            groupBoxTask_OAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxData_OAA.SuspendLayout();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCos_OAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_OAA
            // 
            groupBoxTask_OAA.Controls.Add(pictureBox1);
            groupBoxTask_OAA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTask_OAA.Location = new Point(2, 12);
            groupBoxTask_OAA.Name = "groupBoxTask_OAA";
            groupBoxTask_OAA.Size = new Size(396, 116);
            groupBoxTask_OAA.TabIndex = 0;
            groupBoxTask_OAA.TabStop = false;
            groupBoxTask_OAA.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxData_OAA
            // 
            groupBoxData_OAA.Controls.Add(textBoxStop_OAA);
            groupBoxData_OAA.Controls.Add(textBoxStart_OAA);
            groupBoxData_OAA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxData_OAA.Location = new Point(404, 12);
            groupBoxData_OAA.Name = "groupBoxData_OAA";
            groupBoxData_OAA.Size = new Size(360, 116);
            groupBoxData_OAA.TabIndex = 1;
            groupBoxData_OAA.TabStop = false;
            groupBoxData_OAA.Text = "Ввод данных";
            // 
            // textBoxStop_OAA
            // 
            textBoxStop_OAA.Location = new Point(203, 43);
            textBoxStop_OAA.Name = "textBoxStop_OAA";
            textBoxStop_OAA.Size = new Size(151, 25);
            textBoxStop_OAA.TabIndex = 1;
            // 
            // textBoxStart_OAA
            // 
            textBoxStart_OAA.Location = new Point(6, 43);
            textBoxStart_OAA.Name = "textBoxStart_OAA";
            textBoxStart_OAA.Size = new Size(148, 25);
            textBoxStart_OAA.TabIndex = 0;
            textBoxStart_OAA.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxRes_OAA);
            groupBoxRes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxRes.Location = new Point(8, 134);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(390, 417);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // textBoxRes_OAA
            // 
            textBoxRes_OAA.Location = new Point(3, 21);
            textBoxRes_OAA.Multiline = true;
            textBoxRes_OAA.Name = "textBoxRes_OAA";
            textBoxRes_OAA.Size = new Size(381, 390);
            textBoxRes_OAA.TabIndex = 0;
            // 
            // chartCos_OAA
            // 
            chartArea1.Name = "ChartArea1";
            chartCos_OAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCos_OAA.Legends.Add(legend1);
            chartCos_OAA.Location = new Point(404, 144);
            chartCos_OAA.Name = "chartCos_OAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartCos_OAA.Series.Add(series1);
            chartCos_OAA.Size = new Size(675, 407);
            chartCos_OAA.TabIndex = 2;
            chartCos_OAA.Text = "chart1";
            // 
            // buttonHelp_OAA
            // 
            buttonHelp_OAA.Location = new Point(988, 23);
            buttonHelp_OAA.Name = "buttonHelp_OAA";
            buttonHelp_OAA.Size = new Size(112, 57);
            buttonHelp_OAA.TabIndex = 3;
            buttonHelp_OAA.Text = "Справка";
            buttonHelp_OAA.UseVisualStyleBackColor = true;
            buttonHelp_OAA.Click += buttonHelp_OAA_Click;
            // 
            // buttonDone_OAA
            // 
            buttonDone_OAA.Location = new Point(770, 23);
            buttonDone_OAA.Name = "buttonDone_OAA";
            buttonDone_OAA.Size = new Size(86, 57);
            buttonDone_OAA.TabIndex = 4;
            buttonDone_OAA.Text = "Выполнить";
            buttonDone_OAA.UseVisualStyleBackColor = true;
            buttonDone_OAA.Click += buttonDone_OAA_Click;
            // 
            // buttonSave_OAA
            // 
            buttonSave_OAA.Location = new Point(873, 23);
            buttonSave_OAA.Name = "buttonSave_OAA";
            buttonSave_OAA.Size = new Size(75, 57);
            buttonSave_OAA.TabIndex = 5;
            buttonSave_OAA.Text = "Cохранить";
            buttonSave_OAA.UseVisualStyleBackColor = true;
            buttonSave_OAA.Click += buttonSave_OAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 563);
            Controls.Add(buttonSave_OAA);
            Controls.Add(buttonDone_OAA);
            Controls.Add(buttonHelp_OAA);
            Controls.Add(chartCos_OAA);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxData_OAA);
            Controls.Add(groupBoxTask_OAA);
            Name = "FormMain";
            Text = "Cпринт 6 | Таск 4 | Вариант 10 | Овсепян А.А.";
            groupBoxTask_OAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxData_OAA.ResumeLayout(false);
            groupBoxData_OAA.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartCos_OAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_OAA;
        private PictureBox pictureBox1;
        private GroupBox groupBoxData_OAA;
        private GroupBox groupBoxRes;
        private TextBox textBoxRes_OAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCos_OAA;
        private Button buttonHelp_OAA;
        private TextBox textBoxStart_OAA;
        private TextBox textBoxStop_OAA;
        private Button buttonDone_OAA;
        private Button buttonSave_OAA;
    }
}
