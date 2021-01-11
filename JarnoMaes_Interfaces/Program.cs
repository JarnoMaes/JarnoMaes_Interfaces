using JarnoMaes_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarnoMaes_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction tra1 = new Transaction("0001","2021.01.11",200);
            tra1.ShowTransaction();           
            tra1.GetAmount();
            Console.WriteLine("\n---------Transaction Nr 2----------");
            Transaction tra2 = new Transaction("0002", "2021.01.21", 90);
            tra2.ShowTransaction();           
            tra2.GetAmount();


        }
    }
}
