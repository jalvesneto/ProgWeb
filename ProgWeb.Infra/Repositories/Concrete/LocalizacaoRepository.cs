using ProgWeb.Domain;
using ProgWeb.Domain.Dtos.Localizacao;
using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Interface;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProgWeb.Infra.Repositories.Concrete
{
    public class LocalizacaoRepository : ILocalizacaoRepository
    {
        private readonly IDAO<Localizacao> _localizacaoDAO;
        public LocalizacaoRepository(IDAO<Localizacao> LocalizacaoDAO) 
        {
            _localizacaoDAO = LocalizacaoDAO;
        }

        public Localizacao RegistrarOuAtualizarLocalizacao(Localizacao localizacao)
        {
            var localizacaoOnDb = _localizacaoDAO.Get().Where(x => x.IpAddress == localizacao.IpAddress).FirstOrDefault();
            if (localizacaoOnDb != null)
            {
                if (localizacaoOnDb.CreatedDate.Date == DateTime.Today.Date)
                {
                    return localizacaoOnDb;
                }
                else
                {
                    localizacaoOnDb.Location = localizacao.Location;
                    localizacaoOnDb.CreatedDate = DateTime.Now;
                    localizacaoOnDb.Cidade = localizacao.Cidade;
                    localizacaoOnDb.Pais = localizacao.Pais;
                    localizacaoOnDb.Estado = localizacao.Estado;
                    _localizacaoDAO.Update(localizacaoOnDb);
                    return localizacaoOnDb;
                }
            }
            localizacao.CreatedDate = DateTime.Now;
            _localizacaoDAO.Create(localizacao);
            return localizacao;
        }

        public List<LocalizacaoReponseDto> ObterListaLocalizacoes()
        {
            return _localizacaoDAO.Get().GroupBy(x => new { x.Pais, x.Estado, x.Cidade }).Select(x => new LocalizacaoReponseDto() { Count = x.Count(), DescricaoLocalizacao = x.Key.ToString() }).ToList().OrderByDescending(x => x.Count).ToList();
        }
    }
}
