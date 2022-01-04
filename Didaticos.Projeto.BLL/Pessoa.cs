using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Didaticos.Projeto.BLL
{
    public class Pessoa
    {
        private readonly DAL.PessoaDAL dal;
        public Pessoa()
        {
            dal = new DAL.PessoaDAL();
        }
        public void Update()
        {

        }
        public void Add(ViewModel.PessoaVM pessoa)
        {
            var p = new Model.Pessoa()
            {
                Nome = pessoa.Nome,
                Sobrenome = pessoa.Sobrenome,

            };
            dal.Add(p);
        }
        public List<ViewModel.PessoaVM> GetAll()
        {
            var list = dal.Get();
            return list
                .Select(o => new ViewModel.PessoaVM() 
                {Nome = o.Nome,
                Sobrenome = o.Sobrenome})
                .ToList();
            
        }
        public void Delete()
        {

        }
    }
}
