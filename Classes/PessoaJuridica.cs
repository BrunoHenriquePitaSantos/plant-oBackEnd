using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plantao_UC_COD_BACK.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? Cnpj { get; set; }

        // metodo para inserir um ojeto em arquivo txt
        public void Inserir(PessoaJuridica pj)
        {
            using (StreamWriter sw = new StreamWriter($"{pj.Nome}.txt"))
            {
                sw.WriteLine($"{pj.Nome},{pj.Rendimento},{pj.Cnpj}");
            }
        }
    }

}