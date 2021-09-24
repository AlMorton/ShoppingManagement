using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Shop : Entity
    {
        public string Name { get; private set; }

        public Shop(string name)
        {
            Name = name;
        }

        public Shop()
        {}
    }
}
