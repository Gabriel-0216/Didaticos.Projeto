using Didaticos.Projeto.Model;

namespace Empresa.Projeto.BancoDados
{
    public class PessoaDAO
    {
        private List<Pessoa> lista;
        public PessoaDAO()
        {
            lista = new List<Pessoa>();
        }
        public List<Pessoa> Get()
        {
            return lista;
        }
        public bool Add(Pessoa pessoa)
        {
            lista.Add(pessoa);
            return true;
        }
    }
}