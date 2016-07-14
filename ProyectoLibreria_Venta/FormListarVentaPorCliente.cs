using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librerias;
using Librerias.dal;

namespace ProyectoLibreria_Venta
{
    public partial class FormListarVentaPorCliente : Form
    {
        public FormListarVentaPorCliente()
        {
            InitializeComponent();
            comboBoxCliente.DataSource = ClienteDal.Listar();

        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rut = ((Cliente) comboBoxCliente.SelectedValue).Rut;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = VentaDal.ListaXCliente(rut);

        }
    }
}
