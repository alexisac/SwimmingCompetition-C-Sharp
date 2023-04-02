namespace SwimmingCompetition
{
    partial class FormSearchByTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewSearchByTask = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            ageColumn = new DataGridViewTextBoxColumn();
            distanceColumn = new DataGridViewTextBoxColumn();
            styleColumn = new DataGridViewTextBoxColumn();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchByTask).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSearchByTask
            // 
            dataGridViewSearchByTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchByTask.Columns.AddRange(new DataGridViewColumn[] { nameColumn, ageColumn, distanceColumn, styleColumn });
            dataGridViewSearchByTask.Location = new Point(158, 49);
            dataGridViewSearchByTask.Name = "dataGridViewSearchByTask";
            dataGridViewSearchByTask.RowTemplate.Height = 25;
            dataGridViewSearchByTask.Size = new Size(443, 225);
            dataGridViewSearchByTask.TabIndex = 0;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "nameColumn";
            // 
            // ageColumn
            // 
            ageColumn.HeaderText = "Age";
            ageColumn.Name = "ageColumn";
            // 
            // distanceColumn
            // 
            distanceColumn.HeaderText = "Distance";
            distanceColumn.Name = "distanceColumn";
            // 
            // styleColumn
            // 
            styleColumn.HeaderText = "Style";
            styleColumn.Name = "styleColumn";
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(314, 345);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(118, 37);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // FormSearchByTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(dataGridViewSearchByTask);
            Name = "FormSearchByTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search by task";
            Load += FormSearchByTask_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchByTask).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSearchByTask;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn ageColumn;
        private DataGridViewTextBoxColumn distanceColumn;
        private DataGridViewTextBoxColumn styleColumn;
        private Button buttonBack;
    }
}