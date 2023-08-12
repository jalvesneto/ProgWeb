using ProgWeb.Application.Services.Abstract;
using ProgWeb.Application.Services.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Concrete;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Concrete;
using ProgWeb.Infra.Repositories.Interface;
using System.Text;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Dependecy Injection

#region Services
builder.Services.AddScoped<ILoginService, LoginService>();
#endregion

#region Repositories
builder.Services.AddScoped<IAcompanhamentoOrcamentarioRepository, AcompanhamentoOrcamentarioRepository>();
builder.Services.AddScoped<ISubFuncaoRepository, SubFuncaoRepository>();
builder.Services.AddScoped<IOrgaoRepository, OrgaoRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ILocalizacaoRepository, LocalizacaoRepository>();
#endregion

#region DAOs
builder.Services.AddScoped<IDAO<AcompanhamentoOrcamentario>, AcompanhamentoOrcamentarioDAO>();
builder.Services.AddScoped<IDAO<SubFuncao>, SubFuncaoDAO>();
builder.Services.AddScoped<IDAO<Orgao>, OrgaoDAO>();
builder.Services.AddScoped<IDAO<UnidadeOrcamentaria>, UnidadeOrcamentariaDAO>();
builder.Services.AddScoped<IDAO<Usuario>, UsuarioDAO>();
builder.Services.AddScoped<IDAO<Localizacao>, LocalizacaoDAO>();
#endregion

#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "ProgWeb API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Digite um Token Valido ",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

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

#region AuthOptions
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => {
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Auth:Issuer"],
        ValidAudience = builder.Configuration["Auth:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Auth:Key"]))
    };
});
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
