using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TFYAiK
{
    public class SaveFile
    {
        private string currentFile;
        public SaveFile()
        {
            this.currentFile = null;
        }

        public SaveFile(string name)
        {
            this.currentFile = name;
        }

        public void SaveAs(string text)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text |*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save an Text File";
            saveFileDialog.RestoreDirectory = true; ;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.currentFile = saveFileDialog.FileName;
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(text);
                streamWriter.Close();
            }
        }

        public void Save(string text)
        {
            if (currentFile == null)
            {
                SaveAs(text);
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(currentFile);
                streamWriter.WriteLine(text);
                streamWriter.Close();
            }

        }
    }
}
