using ProgWeb.Domain.Dtos;
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

        public ValoresDto GetValues(
            string funcao,
            string subFuncao,
            string acao,
            string orgao,
            string tituloPrograma,
            string tipoPrograma,
            string localizador,
            string unidadeOrcamentaria
            );

        dynamic SelectSumWhereInQ1(List<int> listParams);
        dynamic SelectSumWhereInQ2(string Param1, string whereTpPrograma, string whereTAcao);
        dynamic SelectSumWhereInQ3(List<string> listParams);
        dynamic SelectSumWhereInQ4(string Param1, string Param2, string Param3);
        dynamic SelectSumWhereInQ5(string Param1, string Param2);
        dynamic SelectSumQ6();
        dynamic SelectSumQ7(int cd_Descricao);
        dynamic SelectSumQ8(List<string> listParams);
        dynamic SelectSumWhereInQ9(string Param1, string Param2);
        dynamic SelectSumQ10();
    }
}
