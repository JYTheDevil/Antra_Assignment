using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories;
namespace ConsoleApp1.UI
{
    internal class No2
    {
        IVillianRepo _repository;
        public No2()
        {
            _repository = new VillianRepository();
        }

        void PrintVillian()
        {
            dynamic d  = _repository.GetVillianName();
            foreach(dynamic villains in d)
            {
                Console.WriteLine($"{villains.Name} \t {villains.total}");
            }
        }
        public void Run()
        {
            PrintVillian();
        }
    }
}
