using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories;
namespace ConsoleApp1.UI
{
    public class No5
    {
        No5_Repo repo;
        public No5()
        {
            repo = new No5_Repo();
        }

        void CasingName()
        {
            int count = 0;
            Console.WriteLine("Enter the Country name: ");
            string name = Console.ReadLine().ToUpper();
            dynamic d = repo.ChangeCasing(name);
            foreach (dynamic item in d)
            {
                count++;
                Console.WriteLine($"{item.TownName}");
            }
            Console.WriteLine($"\n{count} town names were affected");
            
        }
        public void Run()
        {
            CasingName();
        }
    }
}
