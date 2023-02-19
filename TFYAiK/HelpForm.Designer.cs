namespace TFYAiK
{
    partial class HelpForm
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
            this.FileInfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ReferenceTextBox = new System.Windows.Forms.TextBox();
            this.EditInfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.TextInfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StartInfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.InfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // FileInfoLinkLabel
            // 
            this.FileInfoLinkLabel.AutoSize = true;
            this.FileInfoLinkLabel.Location = new System.Drawing.Point(12, 9);
            this.FileInfoLinkLabel.Name = "FileInfoLinkLabel";
            this.FileInfoLinkLabel.Size = new System.Drawing.Size(148, 13);
            this.FileInfoLinkLabel.TabIndex = 0;
            this.FileInfoLinkLabel.TabStop = true;
            this.FileInfoLinkLabel.Text = "Справка по разделу\"Файл\"";
            this.FileInfoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FileInfoLinkLabel_LinkClicked);
            // 
            // ReferenceTextBox
            // 
            this.ReferenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReferenceTextBox.Location = new System.Drawing.Point(12, 43);
            this.ReferenceTextBox.Multiline = true;
            this.ReferenceTextBox.Name = "ReferenceTextBox";
            this.ReferenceTextBox.ReadOnly = true;
            this.ReferenceTextBox.Size = new System.Drawing.Size(776, 395);
            this.ReferenceTextBox.TabIndex = 1;
            // 
            // EditInfoLinkLabel
            // 
            this.EditInfoLinkLabel.AutoSize = true;
            this.EditInfoLinkLabel.Location = new System.Drawing.Point(166, 9);
            this.EditInfoLinkLabel.Name = "EditInfoLinkLabel";
            this.EditInfoLinkLabel.Size = new System.Drawing.Size(160, 13);
            this.EditInfoLinkLabel.TabIndex = 2;
            this.EditInfoLinkLabel.TabStop = true;
            this.EditInfoLinkLabel.Text = "Справка по разделу \"Правка\"";
            this.EditInfoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditInfoLinkLabel_LinkClicked);
            // 
            // TextInfoLinkLabel
            // 
            this.TextInfoLinkLabel.AutoSize = true;
            this.TextInfoLinkLabel.Location = new System.Drawing.Point(332, 9);
            this.TextInfoLinkLabel.Name = "TextInfoLinkLabel";
            this.TextInfoLinkLabel.Size = new System.Drawing.Size(152, 13);
            this.TextInfoLinkLabel.TabIndex = 3;
            this.TextInfoLinkLabel.TabStop = true;
            this.TextInfoLinkLabel.Text = "Справка по разделу \"Текст\"";
            this.TextInfoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TextInfoLinkLabel_LinkClicked);
            // 
            // StartInfoLinkLabel
            // 
            this.StartInfoLinkLabel.AutoSize = true;
            this.StartInfoLinkLabel.Location = new System.Drawing.Point(13, 27);
            this.StartInfoLinkLabel.Name = "StartInfoLinkLabel";
            this.StartInfoLinkLabel.Size = new System.Drawing.Size(147, 13);
            this.StartInfoLinkLabel.TabIndex = 4;
            this.StartInfoLinkLabel.TabStop = true;
            this.StartInfoLinkLabel.Text = "Справка по разделу \"Пуск\"";
            this.StartInfoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StartInfoLinkLabel_LinkClicked);
            // 
            // InfoLinkLabel
            // 
            this.InfoLinkLabel.AutoSize = true;
            this.InfoLinkLabel.Location = new System.Drawing.Point(166, 27);
            this.InfoLinkLabel.Name = "InfoLinkLabel";
            this.InfoLinkLabel.Size = new System.Drawing.Size(165, 13);
            this.InfoLinkLabel.TabIndex = 5;
            this.InfoLinkLabel.TabStop = true;
            this.InfoLinkLabel.Text = "Справка по разделу \"Справка\"";
            this.InfoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InfoLinkLabel_LinkClicked);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoLinkLabel);
            this.Controls.Add(this.StartInfoLinkLabel);
            this.Controls.Add(this.TextInfoLinkLabel);
            this.Controls.Add(this.EditInfoLinkLabel);
            this.Controls.Add(this.ReferenceTextBox);
            this.Controls.Add(this.FileInfoLinkLabel);
            this.Name = "HelpForm";
            this.Text = "TextForm";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel FileInfoLinkLabel;
        private System.Windows.Forms.TextBox ReferenceTextBox;
        private System.Windows.Forms.LinkLabel EditInfoLinkLabel;
        private System.Windows.Forms.LinkLabel TextInfoLinkLabel;
        private System.Windows.Forms.LinkLabel StartInfoLinkLabel;
        private System.Windows.Forms.LinkLabel InfoLinkLabel;
    }
}