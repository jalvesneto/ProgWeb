using ProgWeb.Domain.Dtos;
using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Interface;
using ProgWeb.Util;

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
            user.Password = CalcularHash.CalcularHashSHA256(usuario.Password);
            user.Email = usuario.Email;
            user.CreatedAt = DateTime.Now;
            _usuarioDAO.Create(user);
            return user;
        }

        public Usuario ObterUsuarioByUsernamePassword(string username, string password)
        {
            return (_usuarioDAO.Get().Where(x => (x.UserName.ToLower() == username.ToLower() || x.Email == username) && x.Password == CalcularHash.CalcularHashSHA256(password)).FirstOrDefault());
        }
    }
}
