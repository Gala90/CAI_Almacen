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
        private int cantidad;
        private double precio;




    public Inventario (int codigo, string producto, string marca, int cantidad, double precio)
        {
            this.codigo = codigo;
            this.producto = producto;
            this.marca = marca;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set { this.codigo = value; }
        }

        public string Producto
        {
            get
            {
                return this.producto;
            }
            set { this.producto = value; }
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
            set { this.marca = value; }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set { this.cantidad = value; }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
            set { this.precio = value; }
        }

        public void mostrarProducto()
        {
            Console.WriteLine("Codigo: " + Codigo + " Producto: " + Producto + " Marca: " + Marca + " Cantidad: " + Cantidad + " Precio: " + Precio);
        }


       
    }
}
