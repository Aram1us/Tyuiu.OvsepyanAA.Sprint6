namespace Tyuiu.OvsepyanAA.Sprint6.Task1.V30
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
            groupBoxTask = new GroupBox();
            textBoxCondition = new TextBox();
            groupBoxRes = new GroupBox();
            textBoxRes = new TextBox();
            groupBoxData = new GroupBox();
            textBoxY = new TextBox();
            textBoxX = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxRes.SuspendLayout();
            groupBoxData.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxCondition);
            groupBoxTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTask.Location = new Point(0, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(475, 285);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Location = new Point(6, 24);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(463, 255);
            textBoxCondition.TabIndex = 1;
            textBoxCondition.Text = "Протабулировать функцию cos(x) на заданном диапозоне.\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxRes);
            groupBoxRes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxRes.Location = new Point(514, 12);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(271, 370);
            groupBoxRes.TabIndex = 1;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 24);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ScrollBars = ScrollBars.Vertical;
            textBoxRes.Size = new Size(259, 318);
            textBoxRes.TabIndex = 2;
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(textBoxY);
            groupBoxData.Controls.Add(textBoxX);
            groupBoxData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxData.Location = new Point(0, 316);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(318, 66);
            groupBoxData.TabIndex = 2;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Ввод данных";
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(177, 24);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(135, 25);
            textBoxY.TabIndex = 4;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(6, 24);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(135, 25);
            textBoxX.TabIndex = 3;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Lime;
            buttonDone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDone.Location = new Point(411, 331);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(97, 51);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonHelp.Location = new Point(324, 331);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(81, 51);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 394);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxData);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 30 | Овсепян А.А. ";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            groupBoxData.ResumeLayout(false);
            groupBoxData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxCondition;
        private GroupBox groupBoxRes;
        private TextBox textBoxRes;
        private GroupBox groupBoxData;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
