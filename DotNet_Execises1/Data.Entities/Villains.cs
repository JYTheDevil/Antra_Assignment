using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Villains
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int EvilnessFactorId { get; set; }
        public EvilnessFactors EvilnessFactors { get; set;}
    }
}
