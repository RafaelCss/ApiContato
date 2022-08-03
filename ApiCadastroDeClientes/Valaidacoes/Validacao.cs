using ApiCadastroDeClientes.ViewModel;
using Flunt.Notifications;
using Flunt.Validations;
using System.Diagnostics.Contracts;

namespace ApiCadastroDeClientes.Valaidacoes
{
    public class Validacao : Notifiable<Notification>, INotifiable
    {
        public Validacao(string key , string messagem)
        {

        }
        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            foreach (var item in notifications)
            {
                var notification = new Validacao(item.Key, item.Message);
                AddNotification(notification);
            }
        }

        private void AddNotification(Validacao notification)
        {
           
        }
    }

    public class Contrato : Contract<CadastroViewModel>
    {

    }
}
