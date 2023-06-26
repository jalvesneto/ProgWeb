using ProgWeb.Domain.Dtos;
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

        public ValoresDto GetValues(
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
            var retorno = _acompanhamentoOrcamentarioDAO.Get()
                .Where(e => funcao == "" || e.DescricaoFuncao.Contains(funcao))
                .Where(e => subFuncao == "" || e.TituloAcao.Contains(subFuncao))
                .Where(e => acao == "" || e.TituloAcao.Contains(acao))
                .Where(e => orgao == "" || e.TituloAcao.Contains(orgao))
                .Where(e => tituloPrograma == "" || e.TituloAcao.Contains(tituloPrograma))
                .Where(e => tipoPrograma == "" || e.TituloAcao.Contains(tipoPrograma))
                .Where(e => localizador == "" || e.TituloAcao.Contains(localizador))
                .Where(e => unidadeOrcamentaria == "" || e.TituloAcao.Contains(unidadeOrcamentaria))
                .Where(e => !string.IsNullOrEmpty(e.DotacaoInicial))
                .Where(e => !string.IsNullOrEmpty(e.Empenhado))
                .Where(e => !string.IsNullOrEmpty(e.Liquidado))
                .Where(e => !string.IsNullOrEmpty(e.Pago))
                .Select(e => new ValoresDto{ Empenhado = Convert.ToDecimal(e.Empenhado), 
                    DotacaoInicial = Convert.ToDecimal(e.DotacaoInicial), 
                    Pago = Convert.ToDecimal(e.Pago), 
                    Liquidado = Convert.ToDecimal(e.Liquidado) })
                .ToList();

            ValoresDto valores = new ValoresDto();
            Thread t1 = new Thread(() => valores.Empenhado = retorno.Sum(x => x.Empenhado));
            Thread t2 = new Thread(() => valores.Liquidado = retorno.Sum(x => x.Liquidado));
            Thread t3 = new Thread(() => valores.Pago = retorno.Sum(x => x.Pago));
            Thread t4 = new Thread(() => valores.DotacaoInicial = retorno.Sum(x => x.DotacaoInicial));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();


            return valores;
        }
    }
}
