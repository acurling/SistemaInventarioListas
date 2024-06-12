
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel;

namespace SistemaInventario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clsmenu menu = new Clsmenu();
            menu.principal();

            Console.ReadLine();
        }
    }
}
