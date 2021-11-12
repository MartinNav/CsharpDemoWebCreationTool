using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;


namespace WebPageCreationTool
{
    class Export
    {
        public static void Save(string fileName, string content)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +"\\"+ fileName;

            

             FileStream fs = File.Create(path);
             StreamWriter sr = new StreamWriter(fs);

            sr.WriteLine(content);
            sr.Close();
        }
    }
}
