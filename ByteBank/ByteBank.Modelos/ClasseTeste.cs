using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class ClasseTeste
    {
        ModificadoresTeste teste = new ModificadoresTeste();
        public ClasseTeste()//implicita internal
        {
            teste.MetodoPublico();
            teste.MetodoInternal();// fora da classe porem no mesmo projeto

            // teste.MetodoPrivate(); // visivem apenas na classe ModificadoresTeste
            // teste.MetodoProtected(); // visivel somente na classe ModificadoresTeste ou na classe DerivadaTeste que herda de ModificadoresTeste

        }

    }

    class DerivadaTeste : ModificadoresTeste
    {
        public DerivadaTeste()
        {
            MetodoProtected();
        }

    }

    public class ModificadoresTeste
    {
        public void MetodoPublico() { }
        private void MetodoPrivate() { }
        internal void MetodoInternal() { }
        protected void MetodoProtected() { }
    }
}
