﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApiCadastroDeClientes.Data;
using ApiCadastroDeClientes.Interface;
using ApiCadastroDeClientes.ViewModel;
using ApiCadastroDeClientes.Model;
using System.Configuration;
using Microsoft.Extensions.Options;
using ApiCadastroDeClientes.Services;
using ApiCadastroDeClientes.Funcoes;
using ApiCadastroDeClientes.Notificacoes;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<CadastroDatabaseSettings>(
builder.Configuration.GetSection(nameof(CadastroDatabaseSettings)));
// Add services to the container.
builder.Services.AddSingleton<Cadastro>();

builder.Services.AddControllers()
   .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
        
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();