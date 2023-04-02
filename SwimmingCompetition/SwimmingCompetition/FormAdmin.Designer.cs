namespace SwimmingCompetition
{
    partial class FormAdmin
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
            dataGridViewParticipants = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            ageColumn = new DataGridViewTextBoxColumn();
            dataGridViewTasks = new DataGridView();
            distanceColumn = new DataGridViewTextBoxColumn();
            styleColumn = new DataGridViewTextBoxColumn();
            nrOfParticipantsColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            buttonAddNewParticipant = new Button();
            buttonDeleteParticipant = new Button();
            buttonSearchByTask = new Button();
            buttonAddTaskForParticipant = new Button();
            buttonLogout = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParticipants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewParticipants
            // 
            dataGridViewParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParticipants.Columns.AddRange(new DataGridViewColumn[] { nameColumn, ageColumn });
            dataGridViewParticipants.Location = new Point(23, 58);
            dataGridViewParticipants.Name = "dataGridViewParticipants";
            dataGridViewParticipants.RowTemplate.Height = 25;
            dataGridViewParticipants.Size = new Size(343, 186);
            dataGridViewParticipants.TabIndex = 0;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "nameColumn";
            nameColumn.Width = 150;
            // 
            // ageColumn
            // 
            ageColumn.HeaderText = "Age";
            ageColumn.Name = "ageColumn";
            ageColumn.Width = 150;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Columns.AddRange(new DataGridViewColumn[] { distanceColumn, styleColumn, nrOfParticipantsColumn });
            dataGridViewTasks.Location = new Point(23, 323);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowTemplate.Height = 25;
            dataGridViewTasks.Size = new Size(343, 186);
            dataGridViewTasks.TabIndex = 1;
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
            // nrOfParticipantsColumn
            // 
            nrOfParticipantsColumn.HeaderText = "Number of participants";
            nrOfParticipantsColumn.Name = "nrOfParticipantsColumn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(135, 20);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 2;
            label1.Text = "Participants";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 275);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 3;
            label2.Text = "Tasks";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(541, 59);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(152, 29);
            textBoxName.TabIndex = 4;
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAge.Location = new Point(541, 107);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(152, 29);
            textBoxAge.TabIndex = 5;
            // 
            // buttonAddNewParticipant
            // 
            buttonAddNewParticipant.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddNewParticipant.Location = new Point(467, 199);
            buttonAddNewParticipant.Name = "buttonAddNewParticipant";
            buttonAddNewParticipant.Size = new Size(226, 36);
            buttonAddNewParticipant.TabIndex = 6;
            buttonAddNewParticipant.Text = "Add new participant";
            buttonAddNewParticipant.UseVisualStyleBackColor = true;
            buttonAddNewParticipant.Click += buttonAddNewParticipant_Click;
            // 
            // buttonDeleteParticipant
            // 
            buttonDeleteParticipant.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteParticipant.Location = new Point(467, 262);
            buttonDeleteParticipant.Name = "buttonDeleteParticipant";
            buttonDeleteParticipant.Size = new Size(226, 36);
            buttonDeleteParticipant.TabIndex = 7;
            buttonDeleteParticipant.Text = "Delete participant";
            buttonDeleteParticipant.UseVisualStyleBackColor = true;
            buttonDeleteParticipant.Click += buttonDeleteParticipant_Click;
            // 
            // buttonSearchByTask
            // 
            buttonSearchByTask.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearchByTask.Location = new Point(467, 323);
            buttonSearchByTask.Name = "buttonSearchByTask";
            buttonSearchByTask.Size = new Size(226, 36);
            buttonSearchByTask.TabIndex = 8;
            buttonSearchByTask.Text = "Search by task";
            buttonSearchByTask.UseVisualStyleBackColor = true;
            buttonSearchByTask.Click += buttonSearchByTask_Click;
            // 
            // buttonAddTaskForParticipant
            // 
            buttonAddTaskForParticipant.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddTaskForParticipant.Location = new Point(467, 389);
            buttonAddTaskForParticipant.Name = "buttonAddTaskForParticipant";
            buttonAddTaskForParticipant.Size = new Size(226, 36);
            buttonAddTaskForParticipant.TabIndex = 9;
            buttonAddTaskForParticipant.Text = "Add task for participant";
            buttonAddTaskForParticipant.UseVisualStyleBackColor = true;
            buttonAddTaskForParticipant.Click += buttonAddTaskForParticipant_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.Location = new Point(467, 453);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(226, 36);
            buttonLogout.TabIndex = 10;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(467, 62);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 11;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(467, 110);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 12;
            label4.Text = "Age";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonLogout);
            Controls.Add(buttonAddTaskForParticipant);
            Controls.Add(buttonSearchByTask);
            Controls.Add(buttonDeleteParticipant);
            Controls.Add(buttonAddNewParticipant);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewTasks);
            Controls.Add(dataGridViewParticipants);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewParticipants).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewParticipants;
        private DataGridView dataGridViewTasks;
        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private Button buttonAddNewParticipant;
        private Button buttonDeleteParticipant;
        private Button buttonSearchByTask;
        private Button buttonAddTaskForParticipant;
        private Button buttonLogout;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn ageColumn;
        private DataGridViewTextBoxColumn distanceColumn;
        private DataGridViewTextBoxColumn styleColumn;
        private DataGridViewTextBoxColumn nrOfParticipantsColumn;
    }
}