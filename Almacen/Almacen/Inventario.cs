using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    public class Inventario
    {
        private int codigo;
        private string producto;
        private string marca;
        private int cant;
        private double precio;




    public Inventario (int codigo, string producto, string marca, int cant, double precio)
        {
            this.codigo = codigo;
            this.producto = producto;
            this.marca = marca;
            this.cant = cant;
            this.precio = precio;

        }

    }
}
