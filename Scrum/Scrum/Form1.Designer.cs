namespace Scrum
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.teknikkart = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Testbutton = new MetroFramework.Controls.MetroButton();
            this.Onay = new MetroFramework.Controls.MetroButton();
            this.Done = new MetroFramework.Controls.MetroButton();
            this.Check = new MetroFramework.Controls.MetroButton();
            this.InProgress = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.DoneList = new System.Windows.Forms.ListBox();
            this.CheckList = new System.Windows.Forms.ListBox();
            this.InprogressList = new System.Windows.Forms.ListBox();
            this.TodoList = new System.Windows.Forms.ListBox();
            this.Todo = new MetroFramework.Controls.MetroButton();
            this.Sil = new MetroFramework.Controls.MetroButton();
            this.TaskList = new System.Windows.Forms.DataGridView();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scrumDataSet = new Scrum.scrumDataSet();
            this.tasksTableAdapter = new Scrum.scrumDataSetTableAdapters.TasksTableAdapter();
            this.taskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrumDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // teknikkart
            // 
            this.teknikkart.Location = new System.Drawing.Point(31, 25);
            this.teknikkart.Margin = new System.Windows.Forms.Padding(4);
            this.teknikkart.Name = "teknikkart";
            this.teknikkart.Size = new System.Drawing.Size(168, 28);
            this.teknikkart.TabIndex = 0;
            this.teknikkart.Text = "TEKNİK KART OLUŞTUR";
            this.teknikkart.UseSelectable = true;
            this.teknikkart.Click += new System.EventHandler(this.teknikkart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Testbutton);
            this.groupBox2.Controls.Add(this.Onay);
            this.groupBox2.Controls.Add(this.Done);
            this.groupBox2.Controls.Add(this.Check);
            this.groupBox2.Controls.Add(this.InProgress);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.metroButton4);
            this.groupBox2.Controls.Add(this.metroButton3);
            this.groupBox2.Controls.Add(this.DoneList);
            this.groupBox2.Controls.Add(this.CheckList);
            this.groupBox2.Controls.Add(this.InprogressList);
            this.groupBox2.Controls.Add(this.TodoList);
            this.groupBox2.Location = new System.Drawing.Point(12, 269);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1343, 500);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Testbutton
            // 
            this.Testbutton.Location = new System.Drawing.Point(288, 260);
            this.Testbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Testbutton.Name = "Testbutton";
            this.Testbutton.Size = new System.Drawing.Size(74, 28);
            this.Testbutton.TabIndex = 37;
            this.Testbutton.Text = " TEST ET";
            this.Testbutton.UseSelectable = true;
            this.Testbutton.Click += new System.EventHandler(this.Testbutton_Click);
            // 
            // Onay
            // 
            this.Onay.Location = new System.Drawing.Point(1075, 424);
            this.Onay.Margin = new System.Windows.Forms.Padding(4);
            this.Onay.Name = "Onay";
            this.Onay.Size = new System.Drawing.Size(242, 28);
            this.Onay.TabIndex = 36;
            this.Onay.Text = "İŞİ ONAYLA";
            this.Onay.UseSelectable = true;
            this.Onay.Click += new System.EventHandler(this.Onay_Click);
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Done.Location = new System.Drawing.Point(993, 198);
            this.Done.Margin = new System.Windows.Forms.Padding(4);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(74, 40);
            this.Done.TabIndex = 16;
            this.Done.Text = ">>>>>>>";
            this.Done.UseSelectable = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Check.Location = new System.Drawing.Point(639, 198);
            this.Check.Margin = new System.Windows.Forms.Padding(4);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(74, 40);
            this.Check.TabIndex = 15;
            this.Check.Text = ">>>>>>>";
            this.Check.UseSelectable = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // InProgress
            // 
            this.InProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InProgress.Location = new System.Drawing.Point(288, 198);
            this.InProgress.Margin = new System.Windows.Forms.Padding(4);
            this.InProgress.Name = "InProgress";
            this.InProgress.Size = new System.Drawing.Size(74, 40);
            this.InProgress.TabIndex = 14;
            this.InProgress.Text = ">>>>>>>";
            this.InProgress.UseSelectable = true;
            this.InProgress.Click += new System.EventHandler(this.InProgress_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(1071, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Done";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(728, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Check";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(376, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "In progress";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Todo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(1317, 692);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(196, 54);
            this.metroButton4.TabIndex = 9;
            this.metroButton4.Text = "metroButton4";
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(841, 615);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(196, 54);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "metroButton3";
            this.metroButton3.UseSelectable = true;
            // 
            // DoneList
            // 
            this.DoneList.FormattingEnabled = true;
            this.DoneList.ItemHeight = 16;
            this.DoneList.Location = new System.Drawing.Point(1075, 48);
            this.DoneList.Margin = new System.Windows.Forms.Padding(4);
            this.DoneList.Name = "DoneList";
            this.DoneList.Size = new System.Drawing.Size(242, 356);
            this.DoneList.TabIndex = 6;
            // 
            // CheckList
            // 
            this.CheckList.FormattingEnabled = true;
            this.CheckList.ItemHeight = 16;
            this.CheckList.Location = new System.Drawing.Point(732, 48);
            this.CheckList.Margin = new System.Windows.Forms.Padding(4);
            this.CheckList.Name = "CheckList";
            this.CheckList.Size = new System.Drawing.Size(242, 404);
            this.CheckList.TabIndex = 5;
            // 
            // InprogressList
            // 
            this.InprogressList.FormattingEnabled = true;
            this.InprogressList.ItemHeight = 16;
            this.InprogressList.Location = new System.Drawing.Point(380, 48);
            this.InprogressList.Margin = new System.Windows.Forms.Padding(4);
            this.InprogressList.Name = "InprogressList";
            this.InprogressList.Size = new System.Drawing.Size(242, 404);
            this.InprogressList.TabIndex = 4;
            // 
            // TodoList
            // 
            this.TodoList.FormattingEnabled = true;
            this.TodoList.ItemHeight = 16;
            this.TodoList.Location = new System.Drawing.Point(19, 48);
            this.TodoList.Margin = new System.Windows.Forms.Padding(4);
            this.TodoList.Name = "TodoList";
            this.TodoList.Size = new System.Drawing.Size(248, 404);
            this.TodoList.TabIndex = 3;
            // 
            // Todo
            // 
            this.Todo.Location = new System.Drawing.Point(31, 233);
            this.Todo.Margin = new System.Windows.Forms.Padding(4);
            this.Todo.Name = "Todo";
            this.Todo.Size = new System.Drawing.Size(248, 28);
            this.Todo.TabIndex = 34;
            this.Todo.Text = "SEÇİLEN İŞİ LİSTEYE EKLE";
            this.Todo.UseSelectable = true;
            this.Todo.Click += new System.EventHandler(this.Todo_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(1087, 233);
            this.Sil.Margin = new System.Windows.Forms.Padding(4);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(242, 28);
            this.Sil.TabIndex = 35;
            this.Sil.Text = "SEÇİLEN İŞİ LİSTEDEN SİL";
            this.Sil.UseSelectable = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // TaskList
            // 
            this.TaskList.AutoGenerateColumns = false;
            this.TaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIDDataGridViewTextBoxColumn,
            this.kartNoDataGridViewTextBoxColumn,
            this.taskNameDataGridViewTextBoxColumn,
            this.personelNameDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.taskDateDataGridViewTextBoxColumn,
            this.preDateDataGridViewTextBoxColumn,
            this.realDateDataGridViewTextBoxColumn});
            this.TaskList.DataSource = this.tasksBindingSource;
            this.TaskList.Location = new System.Drawing.Point(12, 60);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(1343, 166);
            this.TaskList.TabIndex = 36;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.scrumDataSet;
            // 
            // scrumDataSet
            // 
            this.scrumDataSet.DataSetName = "scrumDataSet";
            this.scrumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // taskIDDataGridViewTextBoxColumn
            // 
            this.taskIDDataGridViewTextBoxColumn.DataPropertyName = "TaskID";
            this.taskIDDataGridViewTextBoxColumn.HeaderText = "TaskID";
            this.taskIDDataGridViewTextBoxColumn.Name = "taskIDDataGridViewTextBoxColumn";
            this.taskIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // kartNoDataGridViewTextBoxColumn
            // 
            this.kartNoDataGridViewTextBoxColumn.DataPropertyName = "KartNo";
            this.kartNoDataGridViewTextBoxColumn.HeaderText = "KartNo";
            this.kartNoDataGridViewTextBoxColumn.Name = "kartNoDataGridViewTextBoxColumn";
            this.kartNoDataGridViewTextBoxColumn.Width = 60;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "TaskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "TaskName";
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            this.taskNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // personelNameDataGridViewTextBoxColumn
            // 
            this.personelNameDataGridViewTextBoxColumn.DataPropertyName = "PersonelName";
            this.personelNameDataGridViewTextBoxColumn.HeaderText = "PersonelName";
            this.personelNameDataGridViewTextBoxColumn.Name = "personelNameDataGridViewTextBoxColumn";
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "Descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "Descr";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            this.descrDataGridViewTextBoxColumn.Width = 350;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 300;
            // 
            // taskDateDataGridViewTextBoxColumn
            // 
            this.taskDateDataGridViewTextBoxColumn.DataPropertyName = "TaskDate";
            this.taskDateDataGridViewTextBoxColumn.HeaderText = "TaskDate";
            this.taskDateDataGridViewTextBoxColumn.Name = "taskDateDataGridViewTextBoxColumn";
            this.taskDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // preDateDataGridViewTextBoxColumn
            // 
            this.preDateDataGridViewTextBoxColumn.DataPropertyName = "PreDate";
            this.preDateDataGridViewTextBoxColumn.HeaderText = "PreDate";
            this.preDateDataGridViewTextBoxColumn.Name = "preDateDataGridViewTextBoxColumn";
            this.preDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // realDateDataGridViewTextBoxColumn
            // 
            this.realDateDataGridViewTextBoxColumn.DataPropertyName = "RealDate";
            this.realDateDataGridViewTextBoxColumn.HeaderText = "RealDate";
            this.realDateDataGridViewTextBoxColumn.Name = "realDateDataGridViewTextBoxColumn";
            this.realDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 788);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Todo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.teknikkart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "SCRUM TABLOSU";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrumDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton teknikkart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox TodoList;
        private System.Windows.Forms.ListBox InprogressList;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.ListBox DoneList;
        private System.Windows.Forms.ListBox CheckList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton Todo;
        private MetroFramework.Controls.MetroButton Check;
        private MetroFramework.Controls.MetroButton Done;
        private MetroFramework.Controls.MetroButton Sil;
        private MetroFramework.Controls.MetroButton Onay;
        private System.Windows.Forms.DataGridView TaskList;
        private scrumDataSet scrumDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private scrumDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private MetroFramework.Controls.MetroButton Testbutton;
        public MetroFramework.Controls.MetroButton InProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realDateDataGridViewTextBoxColumn;
    }
}

