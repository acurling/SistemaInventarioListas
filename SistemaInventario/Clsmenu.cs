using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    internal class Clsmenu
    {
        int opcion = 0;  // variable globa

        ClsProducto producto = new ClsProducto(0,"",0);
        public Clsmenu()
        {
        }
        public void principal()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1-Ingresar Articulos");
                Console.WriteLine("2-Reporte Articulos");
                Console.WriteLine("3-Asignar bodega");
                Console.WriteLine("4- Reporte bodegas");
                Console.WriteLine("5-salir");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingrese una opcion");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: producto.solicitarDatos();
                            producto.AgregarArticulos();
                        break;
                    case 2: producto.Reporte(); 
                        break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (!opcion.Equals(5));
        }

    }
}
