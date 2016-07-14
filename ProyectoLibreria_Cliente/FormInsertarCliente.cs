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
using Librerias.convertir;
using Librerias.dal;

namespace ProyectoLibreria_Cliente
{
    public partial class FormInsertarCliente : Form
    {
        public FormInsertarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente=new Cliente();
            cliente = ClienteConvertir.CrearCliente(textBoxISBN.Text, textBoxTitulo.Text);
            ClienteDal.Insertar(cliente);
        }
    }
}
