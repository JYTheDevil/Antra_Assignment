using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories;
namespace ConsoleApp1.UI
{
    public class No7
    {
        No7_Repo repo;
        public No7()
        {
            repo = new No7_Repo();
        }

        void PrintName()
        {
            int count = 0, start = 1;
            dynamic d = repo.GetMinionsName();
            foreach (dynamic minions in d)
            {
                count ++;
            }

            dynamic x;
            while(start <= count)
            {
                x = repo.GetMinionsName(start);
                Console.WriteLine($"{x.Name} \t ");
                if (start == count && count %2 != 0) break;
                x = repo.GetMinionsName(count);
                Console.WriteLine($"{x.Name} \t ");
                start ++;
                count --;
            }
        }
        public void Run()
        {
            PrintName();
        }
    }
}