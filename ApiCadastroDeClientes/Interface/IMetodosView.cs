

using Flunt.Notifications;

namespace ApiCadastroDeClientes.Interface
{
    public interface IMetodosView 
    {

        public string ValidarNome(string nome);
        public string ValidarEmail(string email);
        public string ValidarTelefone(string telefone);
        public string ValidarServico(string servico);
        public string ValidarDescricao(string descrcao);
        public DateTime ValidarData(DateTime data);

    }
}
