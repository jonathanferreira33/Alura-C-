using BankYellow.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow.Sistemas
{
    internal class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string senha) 
        {
            bool UsuarioAutenticado = usuario.Autenticar(senha);
            if (UsuarioAutenticado)
            {
                Console.WriteLine($"Bem vindo ao sistema {usuario}");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
