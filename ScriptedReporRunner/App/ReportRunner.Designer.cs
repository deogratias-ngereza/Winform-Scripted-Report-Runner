namespace ScriptedReporRunner.App
{
    partial class ReportRunner
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
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.runReportBtn = new System.Windows.Forms.Button();
            this.reportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.argsTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.configLinkTxt = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.readmeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.logsRichText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(36, 269);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(124, 20);
            this.startDatePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "START-DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "REPORT-RUNNER";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(192, 269);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(124, 20);
            this.endDatePicker.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "START-DATE";
            // 
            // runReportBtn
            // 
            this.runReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runReportBtn.Location = new System.Drawing.Point(36, 378);
            this.runReportBtn.Name = "runReportBtn";
            this.runReportBtn.Size = new System.Drawing.Size(280, 54);
            this.runReportBtn.TabIndex = 2;
            this.runReportBtn.Text = "RUN REPORT";
            this.runReportBtn.UseVisualStyleBackColor = true;
            this.runReportBtn.Click += new System.EventHandler(this.runReportBtn_Click);
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.FormattingEnabled = true;
            this.reportTypeComboBox.Location = new System.Drawing.Point(33, 132);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(280, 21);
            this.reportTypeComboBox.TabIndex = 3;
            this.reportTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.reportTypeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "REPORT-TYPE";
            // 
            // argsTxt
            // 
            this.argsTxt.Location = new System.Drawing.Point(36, 329);
            this.argsTxt.Name = "argsTxt";
            this.argsTxt.Size = new System.Drawing.Size(280, 20);
            this.argsTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "CMD ARGS";
            // 
            // configLinkTxt
            // 
            this.configLinkTxt.AutoSize = true;
            this.configLinkTxt.Location = new System.Drawing.Point(29, 481);
            this.configLinkTxt.Name = "configLinkTxt";
            this.configLinkTxt.Size = new System.Drawing.Size(74, 13);
            this.configLinkTxt.TabIndex = 6;
            this.configLinkTxt.TabStop = true;
            this.configLinkTxt.Text = "Configurations";
            this.configLinkTxt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.configLinkTxt_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Readme";
            // 
            // readmeRichTextBox
            // 
            this.readmeRichTextBox.Location = new System.Drawing.Point(33, 182);
            this.readmeRichTextBox.Name = "readmeRichTextBox";
            this.readmeRichTextBox.Size = new System.Drawing.Size(280, 54);
            this.readmeRichTextBox.TabIndex = 8;
            this.readmeRichTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(949, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "V 1.0";
            // 
            // logsRichText
            // 
            this.logsRichText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.logsRichText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsRichText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.logsRichText.Location = new System.Drawing.Point(351, 132);
            this.logsRichText.Name = "logsRichText";
            this.logsRichText.Size = new System.Drawing.Size(630, 300);
            this.logsRichText.TabIndex = 8;
            this.logsRichText.Text = "Execution \nCommand Scripts\nWill\nCome\nHere";
            // 
            // ReportRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 513);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.logsRichText);
            this.Controls.Add(this.readmeRichTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.configLinkTxt);
            this.Controls.Add(this.argsTxt);
            this.Controls.Add(this.reportTypeComboBox);
            this.Controls.Add(this.runReportBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMDReportRunner,Developer: Grand,org: Gmtech Consult LTD@+255788449030";
            this.Load += new System.EventHandler(this.ReportRunner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button runReportBtn;
        private System.Windows.Forms.ComboBox reportTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox argsTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel configLinkTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox readmeRichTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox logsRichText;
    }
}