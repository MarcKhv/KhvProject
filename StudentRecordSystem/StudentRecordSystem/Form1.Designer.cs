namespace StudentRecordSystem
{
    partial class StudentRecordSystem
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
            this.welcomelabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.autoswitchtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // welcomelabel
            // 
            this.welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.Location = new System.Drawing.Point(72, 184);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(480, 57);
            this.welcomelabel.TabIndex = 0;
            this.welcomelabel.Text = "Welcome Student";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 259);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(541, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // autoswitchtimer
            // 
            this.autoswitchtimer.Interval = 4000;
            this.autoswitchtimer.Tick += new System.EventHandler(this.autoswitchtimer_Tick);
            // 
            // StudentRecordSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 486);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.welcomelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentRecordSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Record System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer autoswitchtimer;
    }
}

