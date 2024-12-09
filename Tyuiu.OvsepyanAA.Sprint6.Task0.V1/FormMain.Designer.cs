namespace Tyuiu.OvsepyanAA.Sprint6.Task0.V1
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
            groupBoxСondition = new GroupBox();
            textBoxTask = new TextBox();
            pictureBoxExample = new PictureBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxRes = new GroupBox();
            textBoxAnswer = new TextBox();
            groupBoxСondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExample).BeginInit();
            groupBoxRes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxСondition
            // 
            groupBoxСondition.Controls.Add(textBoxTask);
            groupBoxСondition.Controls.Add(pictureBoxExample);
            groupBoxСondition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxСondition.Location = new Point(3, 12);
            groupBoxСondition.Name = "groupBoxСondition";
            groupBoxСondition.Size = new Size(774, 249);
            groupBoxСondition.TabIndex = 0;
            groupBoxСondition.TabStop = false;
            groupBoxСondition.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(531, 221);
            textBoxTask.TabIndex = 2;
            textBoxTask.Text = "Дано выражение вычислить его значение при x = 3";
            // 
            // pictureBoxExample
            // 
            pictureBoxExample.Image = (Image)resources.GetObject("pictureBoxExample.Image");
            pictureBoxExample.Location = new Point(565, 10);
            pictureBoxExample.Name = "pictureBoxExample";
            pictureBoxExample.Size = new Size(203, 114);
            pictureBoxExample.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExample.TabIndex = 1;
            pictureBoxExample.TabStop = false;
            // 
            // buttonDone
            // 
            buttonDone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonDone.Location = new Point(629, 367);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(148, 71);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonHelp.Location = new Point(544, 367);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(79, 71);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxAnswer);
            groupBoxRes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxRes.Location = new Point(9, 324);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(364, 114);
            groupBoxRes.TabIndex = 5;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(6, 43);
            textBoxAnswer.Multiline = true;
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(228, 47);
            textBoxAnswer.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRes);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxСondition);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 1 | Овсепян А.А.  ";
            Load += Form1_Load;
            groupBoxСondition.ResumeLayout(false);
            groupBoxСondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExample).EndInit();
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxСondition;
        private PictureBox pictureBoxExample;
        private TextBox textBoxTask;
        private Button buttonDone;
        private Button buttonHelp;
        private GroupBox groupBoxRes;
        private TextBox textBoxAnswer;
    }
}
