using ApiCadastroDeClientes.Data;
using ApiCadastroDeClientes.Funcoes;
using ApiCadastroDeClientes.Interface;
using ApiCadastroDeClientes.Model;
using Flunt.Notifications;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ApiCadastroDeClientes.Services
{
    public class Cadastro : Notifiable<Notification>
    {
        private readonly IMongoCollection<ContatoCliente> _cadastro;
   

        public Cadastro(IOptions<CadastroDatabaseSettings> settings)
        {
            
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _cadastro = database.GetCollection<ContatoCliente>(settings.Value.UsuariosCollectionName);
        }

        public List<ContatoCliente> Get() => _cadastro.Find(usuario => true).ToList();

        public ContatoCliente Get(string id) => _cadastro.Find(usuario => usuario.Id == id).FirstOrDefault();
    
        public ContatoCliente Create(ContatoCliente cadastro)
        {
            var validar = new FuncoesBanco(cadastro.Nome, cadastro.Email, cadastro.Telefone, cadastro.Servico, cadastro.Descricao, cadastro.DataDia);
            if(validar != null)
            {
              _cadastro.InsertOne(cadastro);
            }
            return cadastro;
        }

        public void Upadate(string id, ContatoCliente cadastro) => _cadastro.ReplaceOne(usuario => usuario.Id == id, cadastro);

        public void Remove(ContatoCliente cadastroR) => _cadastro.DeleteOne(cadastro => cadastro == cadastroR);

        public void Remove (string id) => _cadastro.DeleteOne( cadastro => cadastro.Id == id);


    }
}
