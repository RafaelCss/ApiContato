using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace ApiCadastroDeClientes.Model
{
    public class ContatoCliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Servico { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDia { get; set; }

    }
}
