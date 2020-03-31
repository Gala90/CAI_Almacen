using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Almacen
   {
        public class Almacen
        {
            private string nombre;
            private string direccion;
            private List <Inventario> inv;
            private int cantVentas;
            private List<String> empleados;




            public Almacen(string nombre, string direccion)
            {
                this.nombre = nombre;
                this.direccion = direccion;
                cantVentas = 0;
                empleados = new List<string>();
                inv = new List<Inventario>();
            }

            public String Nombre
            {
                get
                {
                    return this.nombre;
                }
                set { this.nombre = value; }
            }

            public String Direccion
            {
                get
                {
                    return this.direccion;
                }
                set { this.direccion = value; }
            }


            public void mostrarAlmacen()
            {
                Console.WriteLine("Nombre: " + Nombre + " Direccion: " + Direccion);
            }

            public void venta()
            {
                 cantVentas = cantVentas + 1;
                 Console.WriteLine("Se ha realizado una venta!");
            }

            public void mostrarCantVentas()
            {
              Console.WriteLine("Cantidad de ventas realizadas: " + cantVentas);
            }

            public void contratarEmpleado(string empleado)
            {
                empleados.Add(empleado);
                Console.WriteLine("Se ha contratado a " + empleado);
            }

            public void agregarProd(string empleado)
            {
              
            }


        public void mostrarEmpleados()
            {
                if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados");
            }
            else
            {

                foreach (string value in empleados)
                {
                    Console.WriteLine(value);
                }
            }

        }

        public void agregarProd(Inventario producto)
        {
            inv.Add(producto);
            Console.WriteLine("Se ha agregado el producto de forma correcta.");
        }

        /*
        public void mostrarInventario()
        {
            if (inv.Count == 0)
            {
                Console.WriteLine("No hay inventario");
            }
            else
            {

                foreach (Inventario value in inv)
                {
                    Console.WriteLine(value);
                }
            }
        }
        */



    }
    }



