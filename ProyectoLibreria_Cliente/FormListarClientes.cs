using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librerias.dal;

namespace ProyectoLibreria_Cliente
{
    public partial class FormListarClientes : Form
    {
        public FormListarClientes()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ClienteDal.Listar();
            

        }
    }
}
