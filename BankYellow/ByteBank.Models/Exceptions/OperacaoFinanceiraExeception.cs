using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow.Exceptions
{
    public class OperacaoFinanceiraExeception : Exception
    {
        public OperacaoFinanceiraExeception() { }
        public OperacaoFinanceiraExeception(string message) : base (message) { }
        public OperacaoFinanceiraExeception(string message, Exception excecaoInterna) : base (message, excecaoInterna) { }

    }
}
