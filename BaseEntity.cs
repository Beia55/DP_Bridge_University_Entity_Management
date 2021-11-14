using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    public abstract class BaseEntity
    {
        public string Name { get; set; }
        public IStorage Storage { get; set; }

        public BaseEntity(string name, IStorage storage)
        {
            this.Name = name;
            this.Storage = storage;
        }

        public abstract void Print();

        public override string ToString()
        {
            return "Name:" + this.Name;
        }
    }
}
