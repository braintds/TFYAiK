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
        private string currentName;
        private string currentDirectory;
        public SaveFile()
        {
            this.currentDirectory = null; this.currentName = null;
        }

        public SaveFile(string name)
        {
            this.currentName = name;
        }

        public void SaveAs(string text)
        {
            if (currentName == null)
            {
                FileStream myStream;
                //вызов окна выбора имени
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text |*.txt|All files (*.*)|*.*";
                saveFileDialog1.Title = "Save an Text File";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = (FileStream)saveFileDialog1.OpenFile()) != null)
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(text);
                        myStream.Write(bytes, 0, text.Length);
                        currentDirectory = myStream.Name;
                        saveFileDialog1.FileName = currentName;
                        myStream.Close();
                    }
                }
            }
        }

        public void Save(string text)
        {
            if (currentName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog(); 
                saveFileDialog.Filter = "Text |*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save an Text File";
                saveFileDialog.RestoreDirectory = true; ;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.WriteLine(text);
                    streamWriter.Close();
                }
            }
            else
            {
                StreamWriter myStream = new StreamWriter(currentDirectory + currentName, false, System.Text.Encoding.ASCII);
            }

        }
    }
}
