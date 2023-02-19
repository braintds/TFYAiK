using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TFYAiK
{
    public partial class MainForm : Form
    {
        SaveFile saveFile = new SaveFile();
        public MainForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFile.Save(textBox.Text);

        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 1000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 250;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(this.saveButton, "Save");
            toolTip.SetToolTip(this.replyButton, "Reply");
            toolTip.SetToolTip(this.returnButton, "Return");
            toolTip.SetToolTip(this.copyButton, "Copy");
            toolTip.SetToolTip(this.pasteButton, "Paste");
            toolTip.SetToolTip(this.cutButton, "Cut");
            toolTip.SetToolTip(this.createNewButton, "CreateNew");
            // open toolTip.SetToolTip();

            //toolTip1.SetToolTip(this.checkBox1, "My checkBox1");
        }


        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.SaveAs(textBox.Text);
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            this.textBox.Visible = true;
        }
    }
}
