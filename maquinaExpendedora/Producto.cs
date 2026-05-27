using System;

namespace MaquinaExpendedora
{
    class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public int Existencia { get; private set; }

        //constructor
        public Producto(string nombre, decimal precio, int existencia)
        {
            Nombre = nombre;
            Precio = precio;
            Existencia = existencia;
        }

        //metodo comprar
        public void Comprar(int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("Cantidad inválida.");
                return;
            }

            if (cantidad > Existencia)
            {
                Console.WriteLine("No hay suficiente inventario.");
                return;
            }

            decimal total = cantidad * Precio;

            Existencia -= cantidad;

            Console.WriteLine("Compra realizada.");
            Console.WriteLine("Total: $" + total);
        }

        //metodo para abastecer
        public void Abastecer(int cantidad)
        {
            if (cantidad > 0)
            {
                Existencia += cantidad;
                Console.WriteLine("Producto abastecido.");
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
        }

        // imprimir información
        public void MostrarInfo()
        {
            Console.WriteLine(
                Nombre +
                " | Precio: $" + Precio +
                " | Existencia: " + Existencia
            );
        }
    }
}