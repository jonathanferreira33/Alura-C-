using BankYellow.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow.Sistemas
{
    public interface Autenticavel 
    {
        bool Autenticar(string senha);
        
        
    }
}
