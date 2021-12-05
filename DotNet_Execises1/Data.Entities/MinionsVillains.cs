using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class MinionsVillains
    {
        public int MinionId { get; set; }
        public int VillianId { get; set; }
        public Minions Minions { get; set; }
        public Villains Villains { get; set; }
    }
}
