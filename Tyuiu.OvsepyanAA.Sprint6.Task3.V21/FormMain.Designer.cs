namespace Tyuiu.OvsepyanAA.Sprint6.Task3.V21
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
            groupBoxCondition = new GroupBox();
            dataGridViewTable = new DataGridView();
            textBoxExamle = new TextBox();
            groupBoxRes = new GroupBox();
            textBoxRes = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable).BeginInit();
            groupBoxRes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(dataGridViewTable);
            groupBoxCondition.Controls.Add(textBoxExamle);
            groupBoxCondition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(523, 207);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие ";
            // 
            // dataGridViewTable
            // 
            dataGridViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable.Location = new Point(263, 24);
            dataGridViewTable.Name = "dataGridViewTable";
            dataGridViewTable.Size = new Size(256, 177);
            dataGridViewTable.TabIndex = 1;
            dataGridViewTable.KeyPress += dataGridViewTable_KeyPress;
            // 
            // textBoxExamle
            // 
            textBoxExamle.Location = new Point(6, 24);
            textBoxExamle.Multiline = true;
            textBoxExamle.Name = "textBoxExamle";
            textBoxExamle.Size = new Size(249, 183);
            textBoxExamle.TabIndex = 0;
            textBoxExamle.Text = "Дан массив 5 на 5 элементов\r\n26 -15   7   1  -4\r\n14  26  22  17  27\r\n-8  31  22  34   4\r\n-18  16  -2  16  27\r\n 5   2  -4  16  15\r\nВыполнить сортировку по возрастанию в первом столбце";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxRes);
            groupBoxRes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxRes.Location = new Point(569, 12);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(200, 93);
            groupBoxRes.TabIndex = 2;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            groupBoxRes.UseWaitCursor = true;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 26);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(188, 25);
            textBoxRes.TabIndex = 3;
            textBoxRes.UseWaitCursor = true;
            
            // 
            // buttonDone
            // 
            buttonDone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDone.Location = new Point(695, 188);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(95, 31);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonHelp.Location = new Point(655, 188);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(34, 31);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 231);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxCondition);
            Name = "FormMain";
            Text = "Cпринт 6 | Таск 3 | Вариант 21 | Овсепян А.А.";
            Load += FormMain_Load;
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable).EndInit();
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private TextBox textBoxExamle;
        private DataGridView dataGridViewTable;
        protected GroupBox groupBoxRes;
        private TextBox textBoxRes;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
