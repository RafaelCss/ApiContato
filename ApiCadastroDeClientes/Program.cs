
using ApiCadastroDeClientes.Data;
using ApiCadastroDeClientes.Funcoes;
using ApiCadastroDeClientes.Interface;
using ApiCadastroDeClientes.Model;
using ApiCadastroDeClientes.Services;



var builder = WebApplication.CreateBuilder(args);


builder.Services.Configure<CadastroDatabaseSettings>(
builder.Configuration.GetSection(nameof(CadastroDatabaseSettings)));
// Add services to the container.
builder.Services.AddSingleton<ContatoCliente>();
builder.Services.AddScoped<IMetodosView, FuncoesBanco>();


builder.Services.AddControllers()
   .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<Cadastro>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
