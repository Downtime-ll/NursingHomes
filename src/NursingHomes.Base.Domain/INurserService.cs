using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomes.Base.Domain
{
    public interface INurserService
    {
        IEnumerable<Nurser> Get();

        Nurser Get(Guid id);

        void Put(Nurser entity);

        void Delete(Guid id);
    }
}
