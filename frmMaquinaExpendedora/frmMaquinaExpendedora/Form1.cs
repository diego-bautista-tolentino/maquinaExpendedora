using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace frmMaquinaExpendedora
{
    public partial class Form1 : Form
    {
        List<Producto> productos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();

            CargarProductos();
            ConfigurarControles();
            ActualizarStockVisual();
            ActualizarTotal();

            // Conectar eventos
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            btnComprar.Click += btnComprar_Click;
        }

        private void CargarProductos()
        {
            productos.Add(new Producto("Agua Natural", 15, 20));
            productos.Add(new Producto("Sabritas", 18, 15));
            productos.Add(new Producto("Snickers", 20, 10));
            productos.Add(new Producto("Chokis", 12, 25));
        }

        private void ConfigurarControles()
        {
            cmbProducto.Items.Clear();

            foreach (Producto producto in productos)
            {
                cmbProducto.Items.Add(producto.Nombre);
            }

            cmbProducto.SelectedIndex = 0;

            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 100;
            nudCantidad.Value = 1;

            lblTotal.Text = "$0.00";
        }

        private void ActualizarTotal()
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                return;
            }

            Producto productoSeleccionado = productos[cmbProducto.SelectedIndex];
            int cantidad = (int)nudCantidad.Value;

            decimal total = productoSeleccionado.Precio * cantidad;

            lblTotal.Text = total.ToString("C2");
        }

        private void ActualizarStockVisual()
        {
            lblStockAgua.Text = "Stock: " + productos[0].Stock;
            lblStockSabritas.Text = "Stock: " + productos[1].Stock;
            lblStockSnickers.Text = "Stock: " + productos[2].Stock;
            lblStockChokis.Text = "Stock: " + productos[3].Stock;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecciona un producto.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Producto productoSeleccionado = productos[cmbProducto.SelectedIndex];
            int cantidad = (int)nudCantidad.Value;

            decimal total;
            string mensaje;

            bool compraExitosa = productoSeleccionado.Comprar(cantidad, out total, out mensaje);

            if (compraExitosa)
            {
                MessageBox.Show(
                    mensaje + "\n\nProducto: " + productoSeleccionado.Nombre +
                    "\nCantidad: " + cantidad +
                    "\nTotal a pagar: " + total.ToString("C2"),
                    "Compra exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ActualizarStockVisual();
                ActualizarTotal();
            }
            else
            {
                MessageBox.Show(
                    mensaje,
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }
    }
}