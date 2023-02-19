using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
                Stream myStream;
                //вызов окна выбора имени
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text |*.txt|All files (*.*)|*.*";
                saveFileDialog1.Title = "Save an Text File";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(text);
                        myStream.Write(bytes, 0, text.Length);
                        myStream.Close();
                    }
                }               
            }
            else
            {
                StreamWriter myStream = new StreamWriter(currentDirectory + currentName, false, System.Text.Encoding.ASCII);            
            }

        }
    }
}
