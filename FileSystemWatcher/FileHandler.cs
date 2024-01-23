using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FileSystemWatcher
{
    class FileHandler
    {
        List<string> LoggedDetail = new List<string>();
        public void Writeer(List<Changes> chang, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try
            {               
                foreach (var item in chang)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            catch (CustomException CE)
            {
                MessageBox.Show(CE.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            sw.Close();
            fs.Close();
        }
        public List<string> Reader(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = "";
            line = sr.ReadLine();
            while (line != null)
            {              
                LoggedDetail.Add(line);
                line = sr.ReadLine();
            }
            return LoggedDetail;
        }
    }
}
