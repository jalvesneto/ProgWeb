using ProgWeb.Domain.Dtos;
using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Interface;

namespace ProgWeb.Infra.Repositories.Concrete
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IDAO<Usuario> _usuarioDAO;
        public UsuarioRepository(IDAO<Usuario> usuarioDAO) 
        {
            _usuarioDAO = usuarioDAO;
        }

        public Usuario RegistrarUsuario(AddUsuarioDto usuario)
        {
            Usuario user = new Usuario();
            user.IdUsuario = new Guid();
            user.UserName = usuario.UserName;
            user.Password = usuario.Password.GetHashCode().ToString();
            user.Email = usuario.Email;
            user.CreatedAt = DateTime.Now;
            _usuarioDAO.Create(user);
            return user;
        }
    }
}
