using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Practica5Mayo
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Venta> ventas = new List<Venta>();

        public Form1()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public class Cliente
        {
            public int IdCliente { get; set; }
            public string Nombre { get; set; }
        }

        public class Venta
        {
            public int IdVenta { get; set; }
            public int IdCliente { get; set; }
            public decimal Importe { get; set; }
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Limpiar listas
                clientes.Clear();
                ventas.Clear();

                // Leer clientes
                foreach (var linea in File.ReadAllLines("clientes.txt"))
                {
                    var datos = linea.Split(',');
                    clientes.Add(new Cliente
                    {
                        IdCliente = int.Parse(datos[0]),
                        Nombre = datos[1]
                    });
                }

                // Leer ventas
                foreach (var linea in File.ReadAllLines("ventas.txt"))
                {
                    var datos = linea.Split(',');
                    ventas.Add(new Venta
                    {
                        IdVenta = int.Parse(datos[0]),
                        IdCliente = int.Parse(datos[1]),
                        Importe = decimal.Parse(datos[2])
                    });
                }

                // Relacionar datos y mostrar en la grilla
                var consulta = from v in ventas
                               join c in clientes on v.IdCliente equals c.IdCliente
                               select new { Cliente = c.Nombre, v.Importe };

                // Limpiar la grilla antes de cargar
                dgvResultados.Rows.Clear();

                foreach (var v in ventas)
                {
                    var cliente = clientes.FirstOrDefault(c => c.IdCliente == v.IdCliente);

                    if (cliente != null)
                    {
                        // Agregar fila con Cliente e Importe
                        dgvResultados.Rows.Add(cliente.Nombre, v.Importe);
                    }
                }


                // Total general
                decimal total = ventas.Sum(v => v.Importe);
                lblTotalVentas.Text = "$" + total;

                // Cliente con mayor compra
                var totalPorCliente = consulta
                    .GroupBy(x => x.Cliente)
                    .Select(g => new { Cliente = g.Key, Total = g.Sum(x => x.Importe) });

                var mayorCompra = totalPorCliente.OrderByDescending(x => x.Total).First();
                lblClienteMayor.Text = $" {mayorCompra.Cliente} ${mayorCompra.Total}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblClienteMayor_Click(object sender, EventArgs e)
        {

        }
    }

}
