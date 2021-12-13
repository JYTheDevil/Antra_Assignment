using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories;
namespace ConsoleApp1.UI
{
    public class No6
    {
        No6_Repo repo;
        public No6()
        {
            repo = new No6_Repo();
        }

        void PrintName()
        {

            Console.WriteLine("Enter the Id");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{repo.DeleteMV(num)} minions were released");
            dynamic d = repo.DeleteV(num);
            Console.WriteLine($"{d.Name} was deleted");


        }
        public void Run()
        {
            PrintName();
        }
    }
}