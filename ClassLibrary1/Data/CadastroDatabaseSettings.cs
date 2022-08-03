using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastroDeClientes.Interface;


namespace ApiCadastroDeClientes.Data
{
    public class CadastroDatabaseSettings : IDBConfiguracao
    {
        public string UsuariosCollectionName { get; set; } = null;
        public string ConnectionString { get; set; } = null;
        public string DatabaseName { get;set; } = null;
    }


}
