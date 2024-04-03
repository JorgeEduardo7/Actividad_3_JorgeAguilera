using Actividad.BSS;
using Actividad.VISTA.PedidoVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.VISTA.ClienteVista
{
    public partial class ClienteSeleccionar : Form
    {
        public ClienteSeleccionar()
        {
            InitializeComponent();
        }
        ClienteBSS bss = new ClienteBSS();
        private void ClienteSeleccionar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PedidoInterfaz.IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
