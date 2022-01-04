using Didaticos.Projeto.Model;
using Empresa.Projeto.BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Didaticos.Projeto.DAL
{
    public class PessoaDAL
    {
        private readonly PessoaDAO _dao;
        public PessoaDAL()
        {
            _dao = new PessoaDAO();
        }
        public void Add(Pessoa pessoa)
        {
            _dao.Add(pessoa);
        }
        public List<Model.Pessoa> Get()
        {
            var list = _dao.Get();
            return list;
        }

    }
}
