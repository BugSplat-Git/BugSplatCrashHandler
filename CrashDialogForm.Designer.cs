namespace BugSplatCrashHandler
{
    partial class CrashDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrashDialogForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.sendErrorReportButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.viewReportDetailsButton = new System.Windows.Forms.Button();
            this.poweredByBugSplatLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your program has encountered an unexpected error.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporting this error will help improve product reliability. All information colle" +
    "cted is confidential and will only be used to improve future versions of this pr" +
    "ogram.";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(11, 205);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(94, 15);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email: (optional)";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(221, 205);
            this.labelName.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(97, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name: (optional)";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(13, 222);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(188, 23);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.Text = "fred@bedrock.com";
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(224, 222);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(188, 23);
            this.usernameTextBox.TabIndex = 6;
            this.usernameTextBox.Text = "Fred";
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please describe the events just before this dialog appeared:";
            // 
            // userDescriptionTextBox
            // 
            this.userDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDescriptionTextBox.Location = new System.Drawing.Point(13, 274);
            this.userDescriptionTextBox.Multiline = true;
            this.userDescriptionTextBox.Name = "userDescriptionTextBox";
            this.userDescriptionTextBox.Size = new System.Drawing.Size(399, 124);
            this.userDescriptionTextBox.TabIndex = 8;
            this.userDescriptionTextBox.TextChanged += new System.EventHandler(this.userDescriptionTextBox_TextChanged);
            // 
            // sendErrorReportButton
            // 
            this.sendErrorReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.sendErrorReportButton.FlatAppearance.BorderSize = 0;
            this.sendErrorReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendErrorReportButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendErrorReportButton.ForeColor = System.Drawing.Color.White;
            this.sendErrorReportButton.Location = new System.Drawing.Point(14, 413);
            this.sendErrorReportButton.Margin = new System.Windows.Forms.Padding(0, 12, 12, 0);
            this.sendErrorReportButton.Name = "sendErrorReportButton";
            this.sendErrorReportButton.Size = new System.Drawing.Size(125, 30);
            this.sendErrorReportButton.TabIndex = 9;
            this.sendErrorReportButton.Text = "Send";
            this.sendErrorReportButton.UseVisualStyleBackColor = false;
            this.sendErrorReportButton.Click += new System.EventHandler(this.sendErrorReportButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(151, 413);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(124, 30);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Don\'t Send";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // viewReportDetailsButton
            // 
            this.viewReportDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewReportDetailsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportDetailsButton.Location = new System.Drawing.Point(287, 413);
            this.viewReportDetailsButton.Margin = new System.Windows.Forms.Padding(0);
            this.viewReportDetailsButton.Name = "viewReportDetailsButton";
            this.viewReportDetailsButton.Size = new System.Drawing.Size(124, 30);
            this.viewReportDetailsButton.TabIndex = 11;
            this.viewReportDetailsButton.Text = "Report Details";
            this.viewReportDetailsButton.UseVisualStyleBackColor = true;
            this.viewReportDetailsButton.Click += new System.EventHandler(this.viewReportDetailsButton_Click);
            // 
            // poweredByBugSplatLabel
            // 
            this.poweredByBugSplatLabel.AutoSize = true;
            this.poweredByBugSplatLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poweredByBugSplatLabel.Location = new System.Drawing.Point(293, 452);
            this.poweredByBugSplatLabel.Name = "poweredByBugSplatLabel";
            this.poweredByBugSplatLabel.Size = new System.Drawing.Size(119, 15);
            this.poweredByBugSplatLabel.TabIndex = 12;
            this.poweredByBugSplatLabel.TabStop = true;
            this.poweredByBugSplatLabel.Text = "Powered by BugSplat";
            this.poweredByBugSplatLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.poweredByBugSplatLabel_LinkClicked);
            // 
            // CrashDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 481);
            this.Controls.Add(this.poweredByBugSplatLabel);
            this.Controls.Add(this.viewReportDetailsButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendErrorReportButton);
            this.Controls.Add(this.userDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrashDialogForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userDescriptionTextBox;
        private System.Windows.Forms.Button sendErrorReportButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button viewReportDetailsButton;
        private System.Windows.Forms.LinkLabel poweredByBugSplatLabel;
    }
}

