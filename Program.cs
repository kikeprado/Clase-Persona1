using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Program
    {        
        static void Main(string[] args)
        {
            Profesor objH = new Profesor("Luisito", 21, 73.2, 3, 7, "Programador");
            Console.WriteLine("su area es: " + objH.Area + " y la cantidad de años es: " + objH.AnnosTrabajando1);
            Console.ReadKey();
        }
    }
}



            

