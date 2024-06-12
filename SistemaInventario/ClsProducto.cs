
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    internal class ClsProducto
    {

        //atributos
        private int codigo;
        private string descripcion;
        private float precio;
       
        List<ClsProducto> articulos = new List<ClsProducto>();

        // constructor 

        public ClsProducto(int Codigo, string Descripcion, float Precio)
        {
            codigo = Codigo;
            descripcion = Descripcion;
            precio = Precio;
        }
        public ClsProducto()
        {
          
        }



        // metodos getter y setter 
        // getter crear una funcion que me devuelve un valor
        // setter crear un procedimiento para asignar un valor

        public int GetCodigo()   // getter del codigo me devuelve el codigo
        {
            return codigo;
        }

        public void SetCodigo(int Codigo)
        {
            codigo = Codigo;
        }


        public string Getdescripcion()   // getter del codigo me devuelve el codigo
        {
            return descripcion;
        }

        public void Setdescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public float Getprecio()   // getter del codigo me devuelve el codigo
        {
            return precio * 0.15;
        }

        public void SetPrecio(float precio)
        {
            this.precio = precio;
        }


        // metodos


        public void solicitarDatos()
        {
            Console.Write("Ingrese el codigo: ");
            int.TryParse(Console.ReadLine(), out codigo);
            Console.Write("Ingrese la descripcion: ");
            descripcion = Console.ReadLine();
            Console.Write("Ingrese el precio: ");
            float.TryParse(Console.ReadLine(), out precio);
        }
        public void AgregarArticulos()
        {
           
            Console.Clear();
            ClsProducto nuevoarticulo = new ClsProducto(codigo, descripcion, precio);  // instancia copia de la clase producto
            articulos.Add(nuevoarticulo);
            Console.WriteLine("El articulo ha sido ingresado");
            Console.Read();
        }

        public void Reporte()
        {
            Console.Clear();
            Console.WriteLine("*********** Reporte de Articulos (\"***********");
            Console.WriteLine("_______________________________________________");
            foreach (var art in articulos)
            {
                Console.WriteLine($"codigo {art.codigo} Descripcion: {art.descripcion} Precio: {art.precio}");
            }
            Console.WriteLine("___________________________ FIN DEL REPORTE  ___________________________");
            Console.Read();
        }

    }
}
