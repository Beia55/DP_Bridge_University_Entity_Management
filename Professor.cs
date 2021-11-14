using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    class Professor : BaseEntity
    {
        public string Specification { get; set; }

        public Professor(string specification, string name,IStorage storage)
            : base(name, storage)
        {
            this.Specification = specification;
        }

        public override void Print()
        {
            Console.WriteLine(base.Storage.Save(this));
        }

        public override string ToString()
        {
            return base.ToString() + ", Year: " + this.Specification;
        }
    }
}
