using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    class CSV : IStorage
    {
        public string Save(BaseEntity baseEntity)
        {
            return "CSV saved: "+baseEntity;
        }
    }
}
