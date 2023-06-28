using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Interface;

namespace ProgWeb.Infra.Repositories.Concrete
{
    public class SubFuncaoRepository : ISubFuncaoRepository
    {

        private readonly IDAO<SubFuncao> _subFuncaoDAO;

        public SubFuncaoRepository(IDAO<SubFuncao> subFuncaoDAO)
        {
            _subFuncaoDAO = subFuncaoDAO;
        }

        public List<SubFuncao> GetAllSubFuncoes()
        {
            return _subFuncaoDAO.Get().ToList();          
        }
    }
}
