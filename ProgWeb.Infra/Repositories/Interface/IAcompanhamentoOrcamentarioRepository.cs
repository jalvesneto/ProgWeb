using ProgWeb.Domain.Entities;

namespace ProgWeb.Infra.Repositories.Interface
{
    public interface IAcompanhamentoOrcamentarioRepository
    {
        List<AcompanhamentoOrcamentario> GetObjects(
            int page,
            string funcao,
            string subFuncao,
            string acao,
            string orgao,
            string tituloPrograma,
            string tipoPrograma,
            string localizador,
            string unidadeOrcamentaria
            );
    }
}
