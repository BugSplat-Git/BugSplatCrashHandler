
namespace BugSplatCrashHandler
{
    partial class CrashReportDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrashReportDialog));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.sendErrorReportButton = new System.Windows.Forms.Button();
            this.userDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.viewReportDetailsButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.poweredByBugSplatLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sendErrorReportButton
            // 
            this.sendErrorReportButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.sendErrorReportButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.sendErrorReportButton.FlatAppearance.BorderSize = 0;
            this.sendErrorReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendErrorReportButton.ForeColor = System.Drawing.SystemColors.Info;
            this.sendErrorReportButton.Location = new System.Drawing.Point(22, 397);
            this.sendErrorReportButton.Name = "sendErrorReportButton";
            this.sendErrorReportButton.Size = new System.Drawing.Size(121, 23);
            this.sendErrorReportButton.TabIndex = 0;
            this.sendErrorReportButton.Text = "Send Error Report";
            this.sendErrorReportButton.UseVisualStyleBackColor = false;
            this.sendErrorReportButton.Click += new System.EventHandler(this.sendErrorReportButton_Click);
            // 
            // userDescriptionTextbox
            // 
            this.userDescriptionTextbox.Location = new System.Drawing.Point(21, 275);
            this.userDescriptionTextbox.Multiline = true;
            this.userDescriptionTextbox.Name = "userDescriptionTextbox";
            this.userDescriptionTextbox.Size = new System.Drawing.Size(395, 116);
            this.userDescriptionTextbox.TabIndex = 1;
            this.userDescriptionTextbox.TextChanged += new System.EventHandler(this.userDescriptionTextbox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(160, 397);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Don\'t Send";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // viewReportDetailsButton
            // 
            this.viewReportDetailsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewReportDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewReportDetailsButton.Location = new System.Drawing.Point(280, 397);
            this.viewReportDetailsButton.Name = "viewReportDetailsButton";
            this.viewReportDetailsButton.Size = new System.Drawing.Size(136, 23);
            this.viewReportDetailsButton.TabIndex = 4;
            this.viewReportDetailsButton.Text = "Report Details";
            this.viewReportDetailsButton.UseVisualStyleBackColor = true;
            this.viewReportDetailsButton.Click += new System.EventHandler(this.viewReportDetailsButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorLabel.Location = new System.Drawing.Point(21, 114);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(374, 20);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "Your program has encountered an unexpected error.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reporting this error will help improve product reliability.  All information coll" +
    "ected is confidential and will only be used to improve future versions of this p" +
    "rogram.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please describe the events just before this dialog appeared:";
            // 
            // username
            // 
            this.username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Location = new System.Drawing.Point(233, 218);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(182, 23);
            this.username.TabIndex = 8;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // email
            // 
            this.email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.email.Location = new System.Drawing.Point(22, 218);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(182, 23);
            this.email.TabIndex = 9;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 107);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(21, 200);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(94, 15);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email: (optional)";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(233, 200);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(97, 15);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name: (optional)";
            // 
            // poweredByBugSplatLabel
            // 
            this.poweredByBugSplatLabel.AutoSize = true;
            this.poweredByBugSplatLabel.Location = new System.Drawing.Point(296, 441);
            this.poweredByBugSplatLabel.Name = "poweredByBugSplatLabel";
            this.poweredByBugSplatLabel.Size = new System.Drawing.Size(119, 15);
            this.poweredByBugSplatLabel.TabIndex = 13;
            this.poweredByBugSplatLabel.TabStop = true;
            this.poweredByBugSplatLabel.Text = "Powered by BugSplat";
            this.poweredByBugSplatLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.poweredByBugSplatLabel_LinkClicked);
            // 
            // CrashReportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 465);
            this.Controls.Add(this.poweredByBugSplatLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.viewReportDetailsButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.userDescriptionTextbox);
            this.Controls.Add(this.sendErrorReportButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrashReportDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button sendErrorReportButton;
        private System.Windows.Forms.TextBox userDescriptionTextbox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button viewReportDetailsButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TextBox username;
        private TextBox email;
        private PictureBox pictureBox2;
        private Label emailLabel;
        private Label nameLabel;
        private LinkLabel poweredByBugSplatLabel;
    }
}

