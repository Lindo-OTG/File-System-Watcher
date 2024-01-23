using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemWatcher
{
    class Changes
    {
        private string fileName;
        private string filePath;
        private string typeofChange;
        private DateTime date = DateTime.Parse(DateTime.Now.ToShortDateString());
        private string changedTo;

        public string ChangeTo
        {
            get { return changedTo; }
            set { changedTo = value; }
        }


        public DateTime Date
        {
            get { return date; }
        }


        public string TypeOfCHange
        {
            get { return typeofChange; }
            set { typeofChange = value; }
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public Changes() { }

        public Changes(string fileName, string filePath, string typeofChange, DateTime date, string changedTo)
        {
            this.fileName = fileName;
            this.filePath = filePath;
            this.typeofChange = typeofChange;
            this.date = date;
            this.changedTo = changedTo;
        }
 
        public Changes(string fileName, string filePath, string typeofChange, DateTime date)
        {
            this.fileName = fileName;
            this.filePath = filePath;
            this.typeofChange = typeofChange;
            this.date = date;
        }
        public override string ToString()
        {
            return string.Format(this.fileName + "*" + this.filePath + "*" + this.typeofChange + "*" + this.date);
        }
    }
}
