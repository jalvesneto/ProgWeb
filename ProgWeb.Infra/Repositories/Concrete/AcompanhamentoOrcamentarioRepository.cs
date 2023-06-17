using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Interface;
using System.Xml.Linq;

namespace ProgWeb.Infra.Repositories.Concrete
{
    public class AcompanhamentoOrcamentarioRepository : IAcompanhamentoOrcamentarioRepository
    {
        private readonly IDAO<AcompanhamentoOrcamentario> _acompanhamentoOrcamentarioDAO;

        public AcompanhamentoOrcamentarioRepository(IDAO<AcompanhamentoOrcamentario> acompanhamentoOrcamentarioDAO)
        {
            _acompanhamentoOrcamentarioDAO = acompanhamentoOrcamentarioDAO;
        }

        public List<AcompanhamentoOrcamentario> GetObjects(
            int page,
            string funcao,
            string subFuncao,
            string acao,
            string orgao,
            string tituloPrograma,
            string tipoPrograma,
            string localizador,
            string unidadeOrcamentaria
            )
        {
            List<AcompanhamentoOrcamentario> acompanhamentoOrcamentarios = new List<AcompanhamentoOrcamentario>();
            acompanhamentoOrcamentarios = _acompanhamentoOrcamentarioDAO.Get()
                .Where(e => funcao == "" || e.DescricaoFuncao.Contains(funcao))
                .Where(e => subFuncao == "" || e.TituloAcao.Contains(subFuncao))
                .Where(e => acao == "" || e.TituloAcao.Contains(acao))
                .Where(e => orgao == "" || e.TituloAcao.Contains(orgao))
                .Where(e => tituloPrograma == "" || e.TituloAcao.Contains(tituloPrograma))
                .Where(e => tipoPrograma == "" || e.TituloAcao.Contains(tipoPrograma))
                .Where(e => localizador == "" || e.TituloAcao.Contains(localizador))
                .Where(e => unidadeOrcamentaria == "" || e.TituloAcao.Contains(unidadeOrcamentaria))
                .Skip((page - 1) * 10).Take(10).ToList();
            return acompanhamentoOrcamentarios;
        }
    }
}
