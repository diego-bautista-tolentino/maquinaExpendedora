namespace frmMaquinaExpendedora
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; private set; }

        public Producto(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public bool Comprar(int cantidad, out decimal total, out string mensaje)
        {
            total = 0;

            if (cantidad <= 0)
            {
                mensaje = "La cantidad debe ser mayor a 0.";
                return false;
            }

            if (cantidad > Stock)
            {
                mensaje = "No hay suficiente stock.";
                return false;
            }

            Stock -= cantidad;
            total = Precio * cantidad;
            mensaje = "Compra realizada.";
            return true;
        }
    }
}