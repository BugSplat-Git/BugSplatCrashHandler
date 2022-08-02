namespace BugSplatCrashHandler
{
    partial class CrashDataDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrashDataDetails));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrashDetailsLabel1 = new System.Windows.Forms.Label();
            this.CrashDetailsLabel2 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Directory});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(375, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.HeaderText = "FileName:";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // Directory
            // 
            this.Directory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Directory.HeaderText = "Location:";
            this.Directory.Name = "Directory";
            this.Directory.ReadOnly = true;
            // 
            // CrashDetailsLabel1
            // 
            this.CrashDetailsLabel1.Location = new System.Drawing.Point(12, 19);
            this.CrashDetailsLabel1.Name = "CrashDetailsLabel1";
            this.CrashDetailsLabel1.Size = new System.Drawing.Size(383, 71);
            this.CrashDetailsLabel1.TabIndex = 1;
            this.CrashDetailsLabel1.Text = resources.GetString("CrashDetailsLabel1.Text");
            // 
            // CrashDetailsLabel2
            // 
            this.CrashDetailsLabel2.Location = new System.Drawing.Point(12, 90);
            this.CrashDetailsLabel2.Name = "CrashDetailsLabel2";
            this.CrashDetailsLabel2.Size = new System.Drawing.Size(375, 30);
            this.CrashDetailsLabel2.TabIndex = 2;
            this.CrashDetailsLabel2.Text = "The files below will included with this report to allow detailed analysis of the " +
    "crash.";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(162, 321);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // CrashDataDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 356);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.CrashDetailsLabel2);
            this.Controls.Add(this.CrashDetailsLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrashDataDetails";
            this.Text = "Crash Data Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn Directory;
        private Label CrashDetailsLabel1;
        private Label CrashDetailsLabel2;
        private Button OK;
    }
}