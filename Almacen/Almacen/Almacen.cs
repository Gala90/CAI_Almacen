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
            private Inventario inv;
            private int cantClientesAtendidos;
            private List<String> empleados;




            public Almacen(string nombre, string direccion)
            {
                this.nombre = nombre;
                this.direccion = direccion;
                cantClientesAtendidos = 0;
                empleados = new List<string>();
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


        }
    }



