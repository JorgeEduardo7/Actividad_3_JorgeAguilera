using Actividad.BSS;
using Actividad.MODELOS;
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
    public partial class ClienteDatos : Form
    {
        public ClienteDatos(int id)
        {
            idx = id;
            InitializeComponent();
        }
        int idx = 0;
        Cliente c = new Cliente();
        ClienteBSS bss = new ClienteBSS();
        private void ClienteDatos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClienteDatosBSS(idx);
            dataGridView2.DataSource = bss.ClienteDatosBSS2(idx);
            dataGridView3.DataSource = bss.ClienteDatosBSS3(idx);
        }
    }
}
