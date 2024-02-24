namespace StudentRecordSystem
{
    partial class AddGradeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateAverageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearGradesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAddGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCalcAverage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuClrGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.credithours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradescale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpasim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradesmasktextbox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.credithoursmaskedbox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.helpbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Grades";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuAddGrade,
            this.toolStripMenuCalcAverage,
            this.toolStripMenuClrGrade,
            this.toolStripMenuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateAverageMenuItem,
            this.clearGradesMenuItem,
            this.exitMenuItem});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuFile.Text = "File";
            // 
            // calculateAverageMenuItem
            // 
            this.calculateAverageMenuItem.Name = "calculateAverageMenuItem";
            this.calculateAverageMenuItem.Size = new System.Drawing.Size(193, 26);
            this.calculateAverageMenuItem.Text = "Calculate CGPA";
            this.calculateAverageMenuItem.Click += new System.EventHandler(this.calculateAverageMenuItem_Click);
            // 
            // clearGradesMenuItem
            // 
            this.clearGradesMenuItem.Name = "clearGradesMenuItem";
            this.clearGradesMenuItem.Size = new System.Drawing.Size(193, 26);
            this.clearGradesMenuItem.Text = "Clear Grades";
            this.clearGradesMenuItem.Click += new System.EventHandler(this.clearGradesMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(193, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // toolStripMenuAddGrade
            // 
            this.toolStripMenuAddGrade.Name = "toolStripMenuAddGrade";
            this.toolStripMenuAddGrade.Size = new System.Drawing.Size(82, 24);
            this.toolStripMenuAddGrade.Text = "Add GPA";
            this.toolStripMenuAddGrade.Click += new System.EventHandler(this.toolStripMenuAddGrade_Click);
            // 
            // toolStripMenuCalcAverage
            // 
            this.toolStripMenuCalcAverage.Name = "toolStripMenuCalcAverage";
            this.toolStripMenuCalcAverage.Size = new System.Drawing.Size(143, 24);
            this.toolStripMenuCalcAverage.Text = "Calculate Average";
            this.toolStripMenuCalcAverage.Click += new System.EventHandler(this.toolStripMenuCalcAverage_Click);
            // 
            // toolStripMenuClrGrade
            // 
            this.toolStripMenuClrGrade.Name = "toolStripMenuClrGrade";
            this.toolStripMenuClrGrade.Size = new System.Drawing.Size(107, 24);
            this.toolStripMenuClrGrade.Text = "Clear Grades";
            this.toolStripMenuClrGrade.Click += new System.EventHandler(this.toolStripMenuClrGrade_Click);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(47, 24);
            this.toolStripMenuExit.Text = "Exit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.grade,
            this.credithours,
            this.gradescale,
            this.gpasim});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(188, 46);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(527, 428);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // grade
            // 
            this.grade.Text = "Mark";
            // 
            // credithours
            // 
            this.credithours.Text = "Credit Hours";
            this.credithours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.credithours.Width = 100;
            // 
            // gradescale
            // 
            this.gradescale.Text = "Grade";
            this.gradescale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpasim
            // 
            this.gpasim.Text = "GPA per Semester";
            this.gpasim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gpasim.Width = 170;
            // 
            // gradesmasktextbox
            // 
            this.gradesmasktextbox.Location = new System.Drawing.Point(14, 87);
            this.gradesmasktextbox.Mask = "00";
            this.gradesmasktextbox.Name = "gradesmasktextbox";
            this.gradesmasktextbox.Size = new System.Drawing.Size(146, 22);
            this.gradesmasktextbox.TabIndex = 3;
            this.gradesmasktextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 73);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // credithoursmaskedbox
            // 
            this.credithoursmaskedbox.Location = new System.Drawing.Point(15, 177);
            this.credithoursmaskedbox.Mask = "0";
            this.credithoursmaskedbox.Name = "credithoursmaskedbox";
            this.credithoursmaskedbox.Size = new System.Drawing.Size(146, 22);
            this.credithoursmaskedbox.TabIndex = 7;
            this.credithoursmaskedbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.credithoursmaskedbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.credithourkeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Credit Hour";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpbutton
            // 
            this.helpbutton.Location = new System.Drawing.Point(16, 397);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(153, 77);
            this.helpbutton.TabIndex = 8;
            this.helpbutton.Text = "Help";
            this.helpbutton.UseVisualStyleBackColor = true;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // AddGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 486);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.credithoursmaskedbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gradesmasktextbox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddGradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGradeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAddGrade;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCalcAverage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuClrGrade;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem calculateAverageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearGradesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.MaskedTextBox gradesmasktextbox;
        private System.Windows.Forms.ColumnHeader grade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader credithours;
        private System.Windows.Forms.MaskedTextBox credithoursmaskedbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader gpasim;
        private System.Windows.Forms.Button helpbutton;
        private System.Windows.Forms.ColumnHeader gradescale;
    }
}