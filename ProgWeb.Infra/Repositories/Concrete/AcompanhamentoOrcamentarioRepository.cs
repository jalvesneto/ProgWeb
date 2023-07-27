using ProgWeb.Domain;
using ProgWeb.Domain.Dtos;
using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Interface;
using System.Linq;
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
                .Select(e => new ValoresDto
                {
                    Empenhado = Convert.ToDecimal(e.Empenhado),
                    DotacaoInicial = Convert.ToDecimal(e.DotacaoInicial),
                    Pago = Convert.ToDecimal(e.Pago),
                    Liquidado = Convert.ToDecimal(e.Liquidado)
                })
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

        public dynamic SelectSumWhereInQ1(List<int> listParams)
        {
            ProgWebContext _context = new ProgWebContext();
            var retorno = from aO in _context.AcompanhamentoOrcamentario
                          where listParams.Contains(Convert.ToInt32(aO.CD_Funcao))
                          group new { aO } by aO.DescricaoFuncao into aO
                          select new
                          {
                              Soma = aO.Sum(x => Convert.ToInt64(x.aO.Pago)),
                              DescricaoFuncao = aO.Key
                          };

            return retorno.ToList();
        }

        public dynamic SelectSumWhereInQ2(string Param1, string whereTpPrograma, string whereTAcao)
        {
            ProgWebContext _context = new ProgWebContext();
            var retorno = (from aO in _context.AcompanhamentoOrcamentario
                           where aO.TituloAcao.Contains(Param1)
                           select new
                           {
                               Soma = aO.Pago,
                               Acao = "Acao"
                           })
                          .Union(
                            from aO in _context.AcompanhamentoOrcamentario
                            where aO.TituloAcao.Contains(whereTAcao) || aO.TipoPrograma.Contains(whereTpPrograma) && aO.TituloAcao.Contains(whereTAcao)
                            select new
                            {
                                Soma = aO.Pago,
                                Acao = "Hospitais"
                            }
                            ).ToList();


            double valorAcao = 0;
            double valorHospitais = 0;

            Thread t1 = new Thread(() => valorAcao = retorno.Where(x => x.Acao == "Acao" && x.Soma != "").Sum(x => Convert.ToDouble(x.Soma)));
            Thread t2 = new Thread(() => valorHospitais = retorno.Where(x => x.Acao == "Hospitais" && x.Soma != "").Sum(x => Convert.ToDouble(x.Soma)));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            return new List<object>(){ new { Acao = valorAcao ,Hospitais = valorHospitais}};
        }

        public dynamic SelectSumWhereInQ3(List<string> listParams)
        {
            ProgWebContext _context = new ProgWebContext();
            var retorno = from aO in _context.AcompanhamentoOrcamentario
                          where listParams.Contains(aO.DescricaoFuncao)
                          orderby aO.DescricaosubFuncao
                          group new { aO } by aO.DescricaosubFuncao into aO
                          select new
                          {
                              Soma = aO.Sum(x => Convert.ToInt64(x.aO.Pago)),
                              DescricaoFuncao = aO.Key
                          }

                          ;

            return retorno.ToList().OrderBy(x => x.Soma).Take(3);
        }

        public dynamic SelectSumWhereInQ4(string Param1, string Param2, string Param3)
        {
            ProgWebContext _context = new ProgWebContext();
            var retorno = (from aO in _context.AcompanhamentoOrcamentario
                           where aO.DescricaoFuncao == Param1 && aO.DescricaosubFuncao == Param2
                           select new
                           {
                               Soma = aO.Pago,
                               Query = 1
                           })
                          .Union(
                            from aO in _context.AcompanhamentoOrcamentario
                            where aO.DescricaoFuncao == Param1 && aO.DescricaosubFuncao == Param2 && aO.DescricaoUnidadeOrcamentaria.Contains(Param3)
                            select new
                            {
                                Soma = aO.Pago,
                                Query = 2
                            }
                            ).ToList();


            double valorGeral = 0;
            double valorEspecifico = 0;

            Thread t1 = new Thread(() => valorGeral = retorno.Where(x => x.Query == 1 && x.Soma != "").Sum(x => Convert.ToDouble(x.Soma)));
            Thread t2 = new Thread(() => valorEspecifico = retorno.Where(x => x.Query == 2 && x.Soma != "").Sum(x => Convert.ToDouble(x.Soma)));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            return new List<object>{ new { Geral = valorGeral , Especifico = valorEspecifico } };
        }

        public dynamic SelectSumWhereInQ5(string Param1, string Param2)
        {
            ProgWebContext _context = new ProgWebContext();
            var retorno = (from aO in _context.AcompanhamentoOrcamentario
                           where aO.DescricaoFuncao == Param1 && aO.descricaolocalizador.Contains(Param2)
                           select new
                           {
                               Soma = aO.Pago,
                               Query = 1
                           })
                          .Union(
                            from aO in _context.AcompanhamentoOrcamentario
                            where aO.DescricaoFuncao == Param1
                            select new
                            {
                                Soma = aO.Pago,
                                Query = 2
                            }
                            ).ToList();


            double valorGeral = 0;
            double valorEspecifico = 0;

            Thread t1 = new Thread(() => valorEspecifico = retorno.Where(x => x.Query == 1 && x.Soma != "").Sum(x => Convert.ToDouble(x.Soma)));
            Thread t2 = new Thread(() => valorGeral = retorno.Where(x => x.Query == 2 && x.Soma != "").Sum(x => Convert.ToDouble(x.Soma)));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            return new List<object> { new { Geral = valorGeral , Especifico = valorEspecifico } };
        }

        public dynamic SelectSumQ6()
        {
            ProgWebContext _context = new ProgWebContext();
            var retorno = from aO in _context.AcompanhamentoOrcamentario
                          group new { aO } by aO.DescricaoFuncao into aO
                          select new
                          {
                              Soma = aO.Sum(x => Convert.ToInt64(x.aO.Pago)),
                              DescricaoFuncao = aO.Key
                          }

                          ;

            return retorno.ToList().OrderBy(x => x.Soma).Take(5);
        }

        public dynamic SelectSumQ7(int cd_Descricao)
        {
            ProgWebContext _context = new ProgWebContext();
            var retorno = from aO in _context.AcompanhamentoOrcamentario
                          where Convert.ToInt32(aO.CD_Funcao) == cd_Descricao
                          group new { aO } by aO.DescricaosubFuncao into aO
                          select new
                          {
                              Soma = aO.Sum(x => Convert.ToInt64(x.aO.Pago)),
                              DescricaoSubFuncao = aO.Key
                          }

                          ;

            return retorno.ToList().OrderBy(x => x.Soma).Take(5);
        }

        public dynamic SelectSumQ8(List<string> listParams)
        {
            ProgWebContext _context = new ProgWebContext();
            var retorno = from aO in _context.AcompanhamentoOrcamentario
                          where listParams.Contains(aO.DescricaoUnidadeOrcamentaria)
                          group new { aO } by aO.DescricaoUnidadeOrcamentaria into aO
                          select new
                          {
                              Soma = aO.Sum(x => Convert.ToInt64(x.aO.Pago)),
                              DescricaoUnidadeOrcamentaria = aO.Key
                          }

                          ;

            return retorno.ToList().OrderBy(x => x.Soma).Take(5);
        }

        public dynamic SelectSumWhereInQ9(string Param1, string Param2)
        {
            ProgWebContext _context = new ProgWebContext();
            var retorno = (from aO in _context.AcompanhamentoOrcamentario
                           where aO.DescricaoUnidadeOrcamentaria == Param1
                           select new
                           {
                               Soma = aO.Pago,
                               Query = 1
                           })
                          .Union(
                            from aO in _context.AcompanhamentoOrcamentario
                            where aO.DescricaoOrgao == Param2
                            select new
                            {
                                Soma = aO.Pago,
                                Query = 2
                            }
                            ).ToList();


            double valorGeral = 0;
            double valorEspecifico = 0;

            Thread t1 = new Thread(() => valorEspecifico = retorno.Where(x => x.Query == 1 && x.Soma != "").Sum(x => Convert.ToDouble(x.Soma)));
            Thread t2 = new Thread(() => valorGeral = retorno.Where(x => x.Query == 2 && x.Soma != "").Sum(x => Convert.ToDouble(x.Soma)));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            return new List<object> { new { Geral = valorGeral , Especifico = valorEspecifico } };
        }

        public dynamic SelectSumQ10()
        {
            ProgWebContext _context = new ProgWebContext();
            var retorno = from aO in _context.AcompanhamentoOrcamentario
                          group new { aO } by aO.DescricaoEsfera into aO
                          select new
                          {
                              Soma = aO.Sum(x => Convert.ToInt64(x.aO.Pago)),
                              DescricaoEsfera = aO.Key
                          }

                          ;

            return retorno.ToList().OrderBy(x => x.Soma).Take(5);
        }
    }
}
