using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen miAlmacen = new Almacen("Kwik E Mart", "Calle Falsa 123");

            Inventario item1 = new Inventario(00001, "Papel Higienico", "Elite", 10, 80.50);

            miAlmacen.mostrarAlmacen();

            item1.mostrarProducto();

            miAlmacen.mostrarCantVentas();

            miAlmacen.venta();

            miAlmacen.mostrarCantVentas();

            miAlmacen.venta();

            miAlmacen.mostrarCantVentas();

            miAlmacen.contratarEmpleado("Roger");

            miAlmacen.mostrarEmpleados();

            miAlmacen.agregarProd(item1);



            

            Console.ReadKey();
        }
    }
}
