using System;

namespace MaquinaExpendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto("Coca Cola", 20, 10);
            Producto p2 = new Producto("Sabritas", 18, 7);
            Producto p3 = new Producto("Chocolate", 15, 12);
            Producto p4 = new Producto("Agua", 12, 20);

            int opcion = 0;

            while (opcion != 4)
            {
                Console.WriteLine("\n--- MAQUINA EXPENDEDORA ---");
                Console.WriteLine("1. Ver productos");
                Console.WriteLine("2. Comprar");
                Console.WriteLine("3. Abastecer");
                Console.WriteLine("4. Salir");

                Console.Write("Selecciona una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("\nPRODUCTOS:");

                        Console.Write("1. ");
                        p1.MostrarInfo();

                        Console.Write("2. ");
                        p2.MostrarInfo();

                        Console.Write("3. ");
                        p3.MostrarInfo();

                        Console.Write("4. ");
                        p4.MostrarInfo();

                        break;

                    case 2:

                        Console.WriteLine("\n¿Qué producto deseas comprar?");
                        Console.WriteLine("1. Coca Cola");
                        Console.WriteLine("2. Sabritas");
                        Console.WriteLine("3. Chocolate");
                        Console.WriteLine("4. Agua");

                        int producto = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Cantidad: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());

                        switch (producto)
                        {
                            case 1:
                                p1.Comprar(cantidad);
                                break;

                            case 2:
                                p2.Comprar(cantidad);
                                break;

                            case 3:
                                p3.Comprar(cantidad);
                                break;

                            case 4:
                                p4.Comprar(cantidad);
                                break;

                            default:
                                Console.WriteLine("Producto inválido.");
                                break;
                        }

                        break;

                    case 3:

                        Console.WriteLine("\n¿Qué producto deseas abastecer?");
                        Console.WriteLine("1. Coca Cola");
                        Console.WriteLine("2. Sabritas");
                        Console.WriteLine("3. Chocolate");
                        Console.WriteLine("4. Agua");

                        int opcionProducto = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Cantidad a agregar: ");
                        int agregar = Convert.ToInt32(Console.ReadLine());

                        switch (opcionProducto)
                        {
                            case 1:
                                p1.Abastecer(agregar);
                                break;

                            case 2:
                                p2.Abastecer(agregar);
                                break;

                            case 3:
                                p3.Abastecer(agregar);
                                break;

                            case 4:
                                p4.Abastecer(agregar);
                                break;

                            default:
                                Console.WriteLine("Producto inválido.");
                                break;
                        }

                        break;

                    case 4:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}