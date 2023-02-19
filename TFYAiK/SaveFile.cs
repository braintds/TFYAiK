using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TFYAiK
{
    public class FileProvider
    {
        private string currentFile;

        public FileProvider()
        {
            this.currentFile = null;
        }

        public FileProvider(string name)
        {
            this.currentFile = name;
        }

        public void SaveFileAs(string text)
        {
            if(text == "")
            {
                //exp or smth
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text |*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save an Text File";
            saveFileDialog.RestoreDirectory = true; ;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                this.currentFile = saveFileDialog.FileName;
                streamWriter.WriteLine(text);
                streamWriter.Close();
            }
        }

        public void SaveFile(string text)
        {
            if (currentFile == null)
            {
                SaveFileAs(text);
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(currentFile);
                streamWriter.WriteLine(text);
                streamWriter.Close();
            }
        }

        public void CreateNewFile()
        {
            SaveFileDialog CreateFileDialog = new SaveFileDialog();
            CreateFileDialog.Filter = "Text |*.txt|All files (*.*)|*.*";
            CreateFileDialog.Title = "Создать";

            if (CreateFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                //переделать
                //return "File ne otkrilsya";
            }
            else
            {
                this.currentFile = CreateFileDialog.FileName;

                StreamWriter streamWriter = new StreamWriter(this.currentFile);
                streamWriter.Close();
            }
        }

        public string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text |*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                //переделать
                return "File ne otkrilsya";
            }
            else
            {
                this.currentFile = openFileDialog.FileName;
                StreamReader streamReader = new StreamReader(this.currentFile);
                string fileText = streamReader.ReadToEnd();
                streamReader.Close();
                ///string fileText = System.IO.File.ReadAllText(openFileDialog.FileName);
                return fileText;
            }
        }
    }
}
