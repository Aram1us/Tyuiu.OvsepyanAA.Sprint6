namespace Tyuiu.OvsepyanAA.Sprint6.Task7.V21
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxTask_OAA = new GroupBox();
            textBoxTask_OAA = new TextBox();
            groupBoxData_OAA = new GroupBox();
            dataGridViewLn_OAA = new DataGridView();
            groupBoxRes_OAA = new GroupBox();
            dataGridViewOut_OAA = new DataGridView();
            openFileDialogTask_OAA = new OpenFileDialog();
            toolTip = new ToolTip(components);
            buttonOpen_OAA = new Button();
            buttonDone_OAA = new Button();
            buttonSave_OAA = new Button();
            buttonHelp = new Button();
            saveFileDialogMatrix_OAA = new SaveFileDialog();
            groupBoxTask_OAA.SuspendLayout();
            groupBoxData_OAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLn_OAA).BeginInit();
            groupBoxRes_OAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_OAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_OAA
            // 
            groupBoxTask_OAA.Controls.Add(textBoxTask_OAA);
            groupBoxTask_OAA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTask_OAA.Location = new Point(-2, 192);
            groupBoxTask_OAA.Name = "groupBoxTask_OAA";
            groupBoxTask_OAA.Size = new Size(1301, 100);
            groupBoxTask_OAA.TabIndex = 0;
            groupBoxTask_OAA.TabStop = false;
            groupBoxTask_OAA.Text = "Условие";
            // 
            // textBoxTask_OAA
            // 
            textBoxTask_OAA.Location = new Point(6, 24);
            textBoxTask_OAA.Multiline = true;
            textBoxTask_OAA.Name = "textBoxTask_OAA";
            textBoxTask_OAA.Size = new Size(1289, 70);
            textBoxTask_OAA.TabIndex = 2;
            textBoxTask_OAA.Text = resources.GetString("textBoxTask_OAA.Text");
            // 
            // groupBoxData_OAA
            // 
            groupBoxData_OAA.Controls.Add(dataGridViewLn_OAA);
            groupBoxData_OAA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxData_OAA.Location = new Point(12, 324);
            groupBoxData_OAA.Name = "groupBoxData_OAA";
            groupBoxData_OAA.Size = new Size(618, 253);
            groupBoxData_OAA.TabIndex = 0;
            groupBoxData_OAA.TabStop = false;
            groupBoxData_OAA.Text = "Ввод данных";
            // 
            // dataGridViewLn_OAA
            // 
            dataGridViewLn_OAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLn_OAA.Location = new Point(6, 24);
            dataGridViewLn_OAA.Name = "dataGridViewLn_OAA";
            dataGridViewLn_OAA.Size = new Size(606, 223);
            dataGridViewLn_OAA.TabIndex = 2;
            // 
            // groupBoxRes_OAA
            // 
            groupBoxRes_OAA.Controls.Add(dataGridViewOut_OAA);
            groupBoxRes_OAA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxRes_OAA.Location = new Point(712, 324);
            groupBoxRes_OAA.Name = "groupBoxRes_OAA";
            groupBoxRes_OAA.Size = new Size(587, 253);
            groupBoxRes_OAA.TabIndex = 1;
            groupBoxRes_OAA.TabStop = false;
            groupBoxRes_OAA.Text = "Вывод данных";
            // 
            // dataGridViewOut_OAA
            // 
            dataGridViewOut_OAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_OAA.Location = new Point(6, 24);
            dataGridViewOut_OAA.Name = "dataGridViewOut_OAA";
            dataGridViewOut_OAA.Size = new Size(575, 223);
            dataGridViewOut_OAA.TabIndex = 3;
            // 
            // openFileDialogTask_OAA
            // 
            openFileDialogTask_OAA.FileName = "openFileDialogTask_OAA";
            // 
            // buttonOpen_OAA
            // 
            buttonOpen_OAA.Image = (Image)resources.GetObject("buttonOpen_OAA.Image");
            buttonOpen_OAA.Location = new Point(12, 12);
            buttonOpen_OAA.Name = "buttonOpen_OAA";
            buttonOpen_OAA.Size = new Size(96, 50);
            buttonOpen_OAA.TabIndex = 4;
            buttonOpen_OAA.UseVisualStyleBackColor = true;
            buttonOpen_OAA.Click += buttonOpen_OAA_Click;
            // 
            // buttonDone_OAA
            // 
            buttonDone_OAA.Image = (Image)resources.GetObject("buttonDone_OAA.Image");
            buttonDone_OAA.Location = new Point(137, 12);
            buttonDone_OAA.Name = "buttonDone_OAA";
            buttonDone_OAA.Size = new Size(101, 50);
            buttonDone_OAA.TabIndex = 5;
            buttonDone_OAA.UseVisualStyleBackColor = true;
            buttonDone_OAA.Click += buttonDone_OAA_Click;
            // 
            // buttonSave_OAA
            // 
            buttonSave_OAA.Image = (Image)resources.GetObject("buttonSave_OAA.Image");
            buttonSave_OAA.Location = new Point(267, 12);
            buttonSave_OAA.Name = "buttonSave_OAA";
            buttonSave_OAA.Size = new Size(96, 50);
            buttonSave_OAA.TabIndex = 6;
            buttonSave_OAA.UseVisualStyleBackColor = true;
            buttonSave_OAA.Click += buttonSave_OAA_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(1184, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(109, 57);
            buttonHelp.TabIndex = 7;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 589);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOpen_OAA);
            Controls.Add(buttonDone_OAA);
            Controls.Add(buttonSave_OAA);
            Controls.Add(groupBoxRes_OAA);
            Controls.Add(groupBoxData_OAA);
            Controls.Add(groupBoxTask_OAA);
            Name = "Form1";
            Text = "Cпринт 6 | Таск 7 | Вариант 21 | Овсепян А.А.";
            groupBoxTask_OAA.ResumeLayout(false);
            groupBoxTask_OAA.PerformLayout();
            groupBoxData_OAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLn_OAA).EndInit();
            groupBoxRes_OAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_OAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_OAA;
        private TextBox textBoxTask_OAA;
        private GroupBox groupBoxData_OAA;
        private GroupBox groupBoxRes_OAA;
        private DataGridView dataGridViewLn_OAA;
        private DataGridView dataGridViewOut_OAA;
        private OpenFileDialog openFileDialogTask_OAA;
        private ToolTip toolTip;
        private Button buttonOpen_OAA;
        private Button buttonDone_OAA;
        private Button buttonSave_OAA;
        private Button buttonHelp;
        private SaveFileDialog saveFileDialogMatrix_OAA;
    }
}
