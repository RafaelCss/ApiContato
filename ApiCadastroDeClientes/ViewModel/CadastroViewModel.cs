﻿using ApiCadastroDeClientes.Model;
using ApiCadastroDeClientes.Services;

namespace ApiCadastroDeClientes.ViewModel
{
    public class CadastroViewModel 
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Servico { get; set; }
        public string Descricao{ get; set; }
        public DateTime? DataDia { get;set; }
    }
}