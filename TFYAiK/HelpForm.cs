using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFYAiK
{
    public partial class HelpForm : Form
    {
        public HelpForm(string text)
        {
            InitializeComponent();
            this.ReferenceTextBox.Text = text;
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(PathHelpFiles.WelcomeMessage);
            this.ReferenceTextBox.Text = streamReader.ReadToEnd();
            streamReader.Close();
        }

        private void FileInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader streamReader = new StreamReader(PathHelpFiles.FileReferencePath);
            this.ReferenceTextBox.Text = streamReader.ReadToEnd();
            streamReader.Close();
        }

        private void EditInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader streamReader = new StreamReader(PathHelpFiles.EditReferencePath);
            this.ReferenceTextBox.Text = streamReader.ReadToEnd();
            streamReader.Close();
        }

        private void TextInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader streamReader = new StreamReader(PathHelpFiles.TextReferencePath);
            this.ReferenceTextBox.Text = streamReader.ReadToEnd();
            streamReader.Close();
        }

        private void StartInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader streamReader = new StreamReader(PathHelpFiles.StartReferencePath);
            this.ReferenceTextBox.Text = streamReader.ReadToEnd();
            streamReader.Close();
        }

        private void InfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader streamReader = new StreamReader(PathHelpFiles.HelpReferencePath);
            this.ReferenceTextBox.Text = streamReader.ReadToEnd();
            streamReader.Close();
        }
    }
}
