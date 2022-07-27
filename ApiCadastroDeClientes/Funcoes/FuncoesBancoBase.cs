namespace ApiCadastroDeClientes.Funcoes
{
    public class FuncoesBancoBase
    {

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Servico { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataDia { get; private set; }
    }
}