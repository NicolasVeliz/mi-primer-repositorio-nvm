using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi_primer_repositorio_nvm
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person();
            persona1.Name = "Kai";
            persona1.Age = 20;


            Person persona2 = new Person();
            persona2.Name = "Jamie";
            persona2.Age = 20;

            Console.WriteLine({persona1.Name} "juega con" {persona2.Name});
            Console.ReadKey();
        }


    }  
 }