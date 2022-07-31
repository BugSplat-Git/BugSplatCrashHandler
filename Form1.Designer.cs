
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.viewReportDetailsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendErrorReportButton
            // 
            this.sendErrorReportButton.Location = new System.Drawing.Point(29, 506);
            this.sendErrorReportButton.Name = "sendErrorReportButton";
            this.sendErrorReportButton.Size = new System.Drawing.Size(121, 23);
            this.sendErrorReportButton.TabIndex = 0;
            this.sendErrorReportButton.Text = "Send Error Report";
            this.sendErrorReportButton.UseVisualStyleBackColor = true;
            this.sendErrorReportButton.Click += new System.EventHandler(this.sendErrorReportButton_Click);
            // 
            // userDescriptionTextbox
            // 
            this.userDescriptionTextbox.Location = new System.Drawing.Point(29, 358);
            this.userDescriptionTextbox.Multiline = true;
            this.userDescriptionTextbox.Name = "userDescriptionTextbox";
            this.userDescriptionTextbox.Size = new System.Drawing.Size(401, 116);
            this.userDescriptionTextbox.TabIndex = 1;
            this.userDescriptionTextbox.TextChanged += new System.EventHandler(this.userDescriptionTextbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 221);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(172, 506);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Don\'t Send";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // viewReportDetailsButton
            // 
            this.viewReportDetailsButton.Location = new System.Drawing.Point(294, 506);
            this.viewReportDetailsButton.Name = "viewReportDetailsButton";
            this.viewReportDetailsButton.Size = new System.Drawing.Size(136, 23);
            this.viewReportDetailsButton.TabIndex = 4;
            this.viewReportDetailsButton.Text = "View Report Details";
            this.viewReportDetailsButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(29, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your program has encountered an unexpected error.";
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(29, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reporting this error will help improve product reliability.  All information coll" +
    "ected is confidential and will only be used to improve future versions of this p" +
    "rogram.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(29, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please describe the events just before this dialog appeared:";
            // 
            // CrashReportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 546);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewReportDetailsButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userDescriptionTextbox);
            this.Controls.Add(this.sendErrorReportButton);
            this.Name = "CrashReportDialog";
            this.Text = "Crash Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button sendErrorReportButton;
        private System.Windows.Forms.TextBox userDescriptionTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button viewReportDetailsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

