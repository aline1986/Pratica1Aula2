using Newtonsoft.Json;
using Pratica1Aula2.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica1Aula2.Repositories
{
    /// <summary>
    /// Clase repository ela  Grava , altera , exclui (CRUD) em algum tipo de armazenamento 
    /// </summary>
    public class FuncionarioRepository
    {
       public void EportarDados(Funcionario funcionario)
        {
            ///Serializar(Objeto funcionário convertido para Json)
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);

            ///Abrindo arquivo em modo escrita , passando o Id {empresa.Id} ele sempre vai gravar arquivos diferentes
            var streamWriter = new StreamWriter($"c:\\temp\\funcionario_{funcionario.IdFuncionario}.json");
            streamWriter.WriteLine(json);//escrevendo dados no arquivo json
            streamWriter.Flush();//salvando
            streamWriter.Close();//fechando
        }


    }
}
