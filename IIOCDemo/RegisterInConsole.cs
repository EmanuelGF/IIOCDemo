using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIOCDemo
{
    public class RegisterInConsole : IRegister
    {
        public void RegisterInfo(string message)
        {
            Console.WriteLine($"info : {message}");
        }
    }
}
