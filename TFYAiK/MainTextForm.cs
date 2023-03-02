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
        FileProvider FileProvider = new FileProvider();
        Stack<Func<object>> undoStack = new Stack<Func<object>>();
        Stack<Func<object>> redoStack = new Stack<Func<object>>();
        public MainForm()
        {
            InitializeComponent();
            textBox.KeyDown += textBox_KeyDown;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileProvider.SaveFile(textBox.Text);
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
            toolTip.SetToolTip(this.undoButton, "Reply");
            toolTip.SetToolTip(this.redoButton, "Return");
            toolTip.SetToolTip(this.copyButton, "Copy");
            toolTip.SetToolTip(this.pasteButton, "Paste");
            toolTip.SetToolTip(this.cutButton, "Cut");
            toolTip.SetToolTip(this.createNewButton, "CreateNew");
            // open toolTip.SetToolTip();
            //textBox.CanUndo = true;
            //toolTip1.SetToolTip(this.checkBox1, "My checkBox1");
        }


        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProvider.SaveFileAs(textBox.Text);
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            FileProvider.CreateNewFile();
            this.textBox.Visible = true;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProvider.SaveFile(textBox.Text);
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProvider.CreateNewFile();
            this.textBox.Visible = true;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox.Text = FileProvider.OpenFile();
            this.textBox.Visible = true;
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            if (this.textBox.SelectionLength > 0)
                this.textBox.Paste();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (this.textBox.SelectionLength > 0)
                this.textBox.Copy();
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            if (this.textBox.SelectionLength > 0)
                this.textBox.Cut();
        }

        private void undo(object sender)
        {
            if (undoStack.Count > 0)
            {
                StackPush(sender, redoStack);
                undoStack.Pop()();
            }
        }

        private void redo(object sender)
        {
            if (redoStack.Count > 0)
            {
                StackPush(sender, undoStack);
                redoStack.Pop()();
            }
        }
        private void redoButton_Click(object sender, EventArgs e)
        {
            redo(textBox);
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                StackPush(textBox, redoStack);
                undoStack.Pop()();
            }
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey && ModifierKeys == Keys.Control) { }
            else if (!((e.KeyCode != Keys.U || ModifierKeys != Keys.Control) ))
            {
                undo(sender);
            }
            else if (e.KeyCode == Keys.R && ModifierKeys == Keys.Control)
            {
               redo(sender);
            }
            else
            {
                redoStack.Clear();
                StackPush(sender, undoStack);
            }
        }

        private void StackPush(object sender, Stack<Func<object>> stack)
        {
            TextBox textBox = (TextBox)sender;
            var tBT = textBox.Text(textBox.Text, textBox.SelectionStart);
            stack.Push(tBT);
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox.SelectAll();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox.Clear();
        }

        private void вызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm("");
            helpForm.ShowDialog();
        }


    }

    public static class Extensions
    {
        public static Func<TextBox> Text(this TextBox textBox, string text, int sel)
        {
            return () =>
            {
                textBox.Text = text;
                textBox.SelectionStart = sel;
                return textBox;
            };
        }
    }
}
