using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories;
namespace ConsoleApp1.UI
{
    public class No8
    {
        No8_Repo repo;
        public No8()
        {
            repo = new No8_Repo();
        }

        void PrintName()
        {
            Console.WriteLine("Enter the Id");
            string str = Console.ReadLine();
            string[] strArray = str.Split(' ');
            int [] num = Array.ConvertAll(strArray,int.Parse);
            for (int i = 0; i < num.Length; i++)
            {
                dynamic d = repo.Update(num[i]);
                Console.WriteLine($"{d.Name} \t {d.Age}");
            }
            
        }
        public void Run()
        {
            PrintName();
        }
    }
}
