using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    public interface IStorage
    {
        string Save(BaseEntity baseEntity);
    }
}
