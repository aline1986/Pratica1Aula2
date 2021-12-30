using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica1Aula2.Inputs
{
    public class FuncionarioInputs
    {
        public static string LerNome()
        {
            Console.Write("Informe nome de funcionário...:");
            return Console.ReadLine();

        }

        public static string LerCpf()
        {
            Console.Write("Informe Cpf de funcionário...:");
            return Console.ReadLine();

        }

        public static string LerMatricula()
        {
            Console.Write("Informe matrícula de funcionário...:");
            return Console.ReadLine();

        }

        public static string LerResumoAtividades()
        {
            Console.Write("Informe resumo de atividades de funcionário...:");
            return Console.ReadLine();

        }

        public static int LerSalario()
        {
            Console.Write("Informe o salário de funcionário...: ");
            return (int)double.Parse(Console.ReadLine());
        }

    }
}
