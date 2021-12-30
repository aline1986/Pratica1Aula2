using Pratica1Aula2.Entities;
using Pratica1Aula2.Inputs;
using Pratica1Aula2.Repositories;
using System;
using System.Collections.Generic;

namespace Pratica1Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***INFORMAÇÕES  DE FUNCIONARIO\n***");
            Console.WriteLine("\nDigite os dados de funcionario:\n");

            var funcionario = new Funcionario(); //instancio a variável dependente


            funcionario.IdFuncionario = Guid.NewGuid();
            funcionario.Nome = FuncionarioInputs.LerNome();
            funcionario.Cpf = FuncionarioInputs.LerCpf();
            funcionario.Matricula = FuncionarioInputs.LerMatricula();
            funcionario.ResumoAtividades = FuncionarioInputs.LerResumoAtividades();
            funcionario.Salario = FuncionarioInputs.LerSalario();
            funcionario.Dependentes = new List<Dependente>();

            Console.Write("Informe a quantidade de dependentes: ");
            var quantidadeDependente = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeDependente; i++)
            {
                try
                {

                    Console.WriteLine($"\nInforme o {i}º Dependente:\n");

                    var dependente = new Dependente();

                    dependente.IdDependentes = Guid.NewGuid();
                    dependente.Nome = DependentesInputs.LerNomeDependente();
                    dependente.Idade = DependentesInputs.LerIdadeDependente();

                    //adicionar dependente
                    funcionario.Dependentes.Add(dependente);


                }
                catch(Exception e)
                {

                    Console.WriteLine($"\nErro: + { e.Message}");
                }

            }

            try
            {
                var funcionarioRepository = new FuncionarioRepository();
                funcionarioRepository.EportarDados(funcionario);

                Console.WriteLine("\n DADOS GRAVADOS COM SUCESSO!!");
            }
            catch (Exception e)
            {

                Console.WriteLine($"\nErro ao exportar dados:{e.Message}");
            }   
            Console.ReadKey(); //Pausa o prompt 

        }
    }
}
