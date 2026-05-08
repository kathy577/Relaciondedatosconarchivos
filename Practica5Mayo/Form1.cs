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
        string archivoClientes = "Clientes.txt";
        string archivoVentas = "Ventas.txt";
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
            StreamReader leer = new StreamReader(archivoClientes);
            string registro;
            while (!leer.EndOfStream)
            {
                registro = leer.ReadLine();
                string[] datos = registro.Split(",");

                //logica
                dgvResultados.Rows.Add(datos[1],0);

                //logica


            }
            leer.Close();
            leer.Dispose();


           
        }
        public int DevolverVenta(string idCliente)
        {
            int totalVentas = 0;

            StreamReader leer = new StreamReader (archivoVentas)
            string registro;
            while (!leer.EndOfStream )
            {
                registro = leer.ReadLine();
                string[] datos = registro.Split(",");


            }
        
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
