using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica1Aula2.Inputs
{
   public class DependentesInputs
    {
        /// <summary>
        /// Método p/ ler nome de denpendente
        /// </summary>
        /// <returns> tipo texto </returns>
        public static string LerNomeDependente()
        {
            Console.Write("Informe nome de dependente...:");
            return Console.ReadLine();

        }

        public static int LerIdadeDependente()
        {
            Console.Write("Informe a idade de dependente...: ");
            return int.Parse(Console.ReadLine());
        }


    }
}
