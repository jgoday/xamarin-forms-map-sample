using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMap.Services
{
    public interface ICadastralService
    {
        Task<string> FindCadastralReference(
            double lat,
            double lon);
    }
}
