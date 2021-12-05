using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories;
namespace ConsoleApp1.UI
{
    internal class No3
    {
        
        IMinionNameRepo2 repo;
        public No3()
        {
            repo = new MinionRepository();
            
            
        }
        void PrintMinions()
        {
            Minions minions = new Minions();
            Console.WriteLine("Enter Id = ");
            minions.Id = Convert.ToInt32(Console.ReadLine());
            if (repo.checkExist(minions.Id) == false)
                Console.WriteLine("No villain with ID <VillainId> exists in the database.");
            else
            {
                dynamic collection = repo.GetMinionsName(minions.Id);
                foreach (dynamic item in collection)
                {
                    Console.WriteLine($"{item.VilliansId} \t{item.VilliansName} \t{item.MinionsName}\t{item.Age}");
                }

            }

        }
        public void Run()
        {
            PrintMinions();
        }
    }
}
