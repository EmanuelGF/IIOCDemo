using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIOCDemo
{
    public class RegisterInFile : IRegister
    {
        private readonly string _pathToFile;
        public RegisterInFile(string path)
        {
            _pathToFile = path;
        }

        public void RegisterInfo(string message)
        {
            Log(message);
        }

        private void Log(string message)
        {
            using (var streamWriter = new StreamWriter(_pathToFile, true))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}
