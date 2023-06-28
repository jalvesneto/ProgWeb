using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgWeb.Infra.Repositories.Concrete
{
    public class OrgaoRepository : IOrgaoRepository
    {
        private readonly IDAO<Orgao> _orgaoDAO;
        public OrgaoRepository(IDAO<Orgao> orgaoDAO) { 
            _orgaoDAO = orgaoDAO;
        }

        public List<Orgao> Getall()
        {
            return _orgaoDAO.Get().ToList();
        }
    }
}
