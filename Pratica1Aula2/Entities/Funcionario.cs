using System;
using System.Collections.Generic; //faz a dependencia ter acende esta biblioteca de coleçaões
using System.Text;

namespace Pratica1Aula2.Entities
{
    public class Funcionario 
    {
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }
        public string ResumoAtividades { get; set; }

        /// <summary>
        /// Funcionari tem uma lista de dependentes (dependencia ter)
        /// </summary>
        public List<Dependente> Dependentes { get; set; }
       //tipo é List <da classe Dependente > Nome da lista é Dependentes


    }
}
