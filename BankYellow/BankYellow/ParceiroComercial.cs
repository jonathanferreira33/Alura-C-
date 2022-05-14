using BankYellow.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow
{
    public class ParceiroComercial : IAutenticavel
    {
       

        public string Senha { get; internal set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    
    }
}
