using ProgWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgWeb.Infra.Repositories.Interface
{
    public interface ISubFuncaoRepository
    {

        List<SubFuncao> GetAllSubFuncoes();
    }   
}
