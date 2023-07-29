using ProgWeb.Domain.Dtos;
using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Interface;

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
                    _localizacaoDAO.Update(localizacaoOnDb);
                    return localizacaoOnDb;
                }
            }
            localizacao.CreatedDate = DateTime.Now;
            _localizacaoDAO.Create(localizacao);
            return localizacao;
        }
    }
}
