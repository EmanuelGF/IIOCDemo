using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIOCDemo
{
    class RegisterOcurrances
    {
        private readonly IRegister _register;

        public RegisterOcurrances(IRegister register)
        {
            _register = register;
        }

        public void Register(string message)
        {
            _register.RegisterInfo($"{message} : {DateTime.Now }");
        }
    }
}
