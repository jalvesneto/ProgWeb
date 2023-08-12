using ProgWeb.Domain.Dtos;
using ProgWeb.Domain.Entities;

namespace ProgWeb.Infra.Repositories.Interface
{
    public interface IUsuarioRepository
    {
        Usuario RegistrarUsuario(AddUsuarioDto usuario);
        Usuario ObterUsuarioByUsernamePassword(string username, string password);
    }
}
