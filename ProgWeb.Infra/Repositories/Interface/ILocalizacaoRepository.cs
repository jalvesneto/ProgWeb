using ProgWeb.Domain.Dtos;
using ProgWeb.Domain.Entities;

namespace ProgWeb.Infra.Repositories.Interface
{
    public interface ILocalizacaoRepository
    {
        Localizacao RegistrarOuAtualizarLocalizacao(Localizacao localizacao);
    }
}
