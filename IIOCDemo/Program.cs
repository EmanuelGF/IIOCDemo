using System;

namespace IIOCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var registerInConsole = new RegisterOcurrances(new RegisterInConsole());
            registerInConsole.Register("Registered ocurrence in console");

            var registerInFile = new RegisterOcurrances(new RegisterInFile(@"c:\test.txt"));
            registerInFile.Register("Registered ocurrence in file.");

            Console.ReadLine();
        }
    }
}
