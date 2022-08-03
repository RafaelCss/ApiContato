namespace ApiCadastroDeClientes.Interface
{
    public interface IDBConfiguracao
    {
        public string UsuariosCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
