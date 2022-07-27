using ApiCadastroDeClientes.Interface;
using Flunt.Notifications;
using Flunt.Validations;

namespace ApiCadastroDeClientes.Funcoes
{
    public class FuncoesBanco : Notifiable<Notification>, IMetodosView

    {
      
        public FuncoesBanco(string nome, string email, string telefone, string servico, string descricao, DateTime data)
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



        public DateTime ValidarData(DateTime data)
        {
            DataDia = DateTime.Now.ToLocalTime();
            

            return DataDia;
        }

    

        public string ValidarDescricao(string descricao)
        {
            Descricao = descricao;
            AddNotifications(new Contract<FuncoesBanco>()
            .Requires()
            .IsNullOrEmpty(Descricao, "Este campo não pode ficar vazio"));
            return Descricao;
        }

        public string ValidarEmail(string email)
        {
            Email = email;
            AddNotifications(new Contract<FuncoesBanco>()
            .Requires()
            .IsEmail(Email, "Este campo não pode ficar vazio"));
            return Email;
        }

        public string ValidarNome(string nome)
        {
            Nome = nome;
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

      
    }
}
