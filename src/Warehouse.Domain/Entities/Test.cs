using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Domain.Entities
{
    public struct Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Test()
        {
            Name = "2";
            Id = 2;
        }
    }
}
