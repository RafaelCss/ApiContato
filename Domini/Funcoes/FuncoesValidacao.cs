using ApiCadastroDeClientes.Interface;
using ApiCadastroDeClientes.Valaidacoes;
using ApiCadastroDeClientes.ViewModel;
using Flunt.Notifications;
using Flunt.Validations;

namespace ApiCadastroDeClientes.Funcoes
{
    public class FuncoesDeValidacao : IMetodosView
    {
        # region Construtor

        private readonly Validacao _validacao;
        public FuncoesDeValidacao()
        {
           
        }
    
      
        public FuncoesDeValidacao(string nome, string email, string telefone, string servico, string descricao, DateTime data)
        {
            ValidarNome(nome);
            ValidarData(data);
            ValidarDescricao(descricao);
            ValidarEmail(email);
            ValidarTelefone(telefone);
            ValidarServico(servico);
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Servico { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataDia { get; private set; }

        #endregion

        #region Metódos 

        public DateTime ValidarData(DateTime data)
        {
            DataDia = DateTime.Now.ToLocalTime();
            return DataDia;
        }

    

        public string ValidarDescricao(string descricao)
        {
            Descricao = descricao;
                _validacao.AddNotifications(new Contrato()
                    .Requires()
                    .IsNotNullOrEmpty(Descricao, "Descricao", "Este campo não pode ser vazio"));

            return Descricao;
        }

        public string ValidarEmail(string email)
        {
         
            Email = email;
            _validacao.AddNotifications(new Contrato().Requires()
               .IsNotNullOrEmpty(Email,"Email","Este campo não pode ficar vazio")
               .IsNotEmail(Email,"Email", "Isso não é uma email")
               );
            return Email;
        }

        public string ValidarNome(string nome)
        {
          
           Nome = nome;
                _validacao.AddNotifications(new Contrato()
                    .Requires()
                    .IsNotNullOrEmpty(Nome, "Nome", "Este campo não pode ser vazio"));

            return Nome;
        }

        public string ValidarServico(string servico)
        {
            Servico = servico;
            return Servico;
        }

        public string ValidarTelefone(string telefone)
        {
            Telefone = telefone;
            return Telefone;
        }

        #endregion
    }
}
