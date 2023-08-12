using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ProgWeb.Application.Services.Abstract;
using ProgWeb.Domain.Entities;
using ProgWeb.Infra.Repositories.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProgWeb.Application.Services.Concrete
{
    public class LoginService : ILoginService
    {
        private readonly IConfiguration _configuration;
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginService(IConfiguration configuration, IUsuarioRepository usuarioRepository) 
        {
            _configuration = configuration;
            _usuarioRepository = usuarioRepository;
        }

        public string Login(string username, string password)
        {
            Usuario user = _usuarioRepository.ObterUsuarioByUsernamePassword(username, password);
            if (user == null) throw new ArgumentException("Usuario ou senha invalidos.");
            return GenerateToken(user);
        }

        private string GenerateToken(Usuario user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Auth:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier ,user.UserName),
                new Claim(ClaimTypes.Email, user.Email)
            };
            var token = new JwtSecurityToken(_configuration["Auth:Issuer"],
                _configuration["Auth:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);


            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
