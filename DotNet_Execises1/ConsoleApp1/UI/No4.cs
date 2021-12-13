using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories;
namespace ConsoleApp1.UI
{
     class No4
    {
        No4_Repo repo;
        public No4()
        {
            repo = new No4_Repo();
        }

        void AddProduct()
        {
            Minions minions = new Minions();
            Console.Write("Enter Id = ");
            minions.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name = ");
            minions.Name = Console.ReadLine();
            Console.Write("Enter Age = ");
            minions.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Townid = ");
            minions.TownId = Convert.ToInt32(Console.ReadLine());
            

            if (repo.Insert(minions) > 0)
                Console.WriteLine("Product added successfully");
            else
                Console.WriteLine("Some Error has occured");
        }
    }
}
