using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Concrete;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Concrete;
using ProgWeb.Infra.Repositories.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IAcompanhamentoOrcamentarioRepository, AcompanhamentoOrcamentarioRepository>();
builder.Services.AddScoped<IDAO<AcompanhamentoOrcamentario>, AcompanhamentoOrcamentarioDAO>();
builder.Services.AddScoped<ISubFuncaoRepository, SubFuncaoRepository>();
builder.Services.AddScoped<IDAO<SubFuncao>, SubFuncaoDAO>();
builder.Services.AddScoped<IOrgaoRepository, OrgaoRepository>();
builder.Services.AddScoped<IDAO<Orgao>, OrgaoDAO>();
builder.Services.AddScoped<IDAO<UnidadeOrcamentaria>, UnidadeOrcamentariaDAO>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "cors",
        builder =>
        {
            builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .WithMethods("PUT", "DELETE", "GET", "POST")
            .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
