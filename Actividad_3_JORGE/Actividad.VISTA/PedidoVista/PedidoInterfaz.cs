using Actividad.BSS;
using Actividad.MODELOS;
using Actividad.VISTA.ClienteVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Actividad.VISTA.PedidoVista
{
    public partial class PedidoInterfaz : Form
    {
        public PedidoInterfaz()
        {
            InitializeComponent();
        }
        PedidoBSS bss = new PedidoBSS();
        ClienteBSS bssuser = new ClienteBSS();
        public static int IdClienteSeleccionada = 0;
        private void PedidoInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPedidoBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido u = new Pedido();
            u.IdCliente = IdClienteSeleccionada;
            u.Total = Convert.ToDecimal(textBox2.Text);
            u.Fecha = dateTimePicker1.Value;

            bss.InsertarPedidoBss(u);
            MessageBox.Show("Se guardó correctamente");

            dataGridView1.DataSource = bss.ListarPedidoBss();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClienteSeleccionar fr = new ClienteSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente p = bssuser.ObtenerClienteIdBss(IdClienteSeleccionada);
                textBox1.Text = p.Nombre + " " + p.Apellido;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Pedido editarPedido = bss.ObtenerPedidoIdBss(IdPedidoSeleccionada);
            editarPedido.IdCliente = IdClienteSeleccionada;
            editarPedido.Fecha = dateTimePicker1.Value;
            editarPedido.Total = Convert.ToDecimal(textBox2.Text);
            bss.EditarPedidoBss(editarPedido);
            MessageBox.Show("Datos Actualizados Correctamente");

            dataGridView1.DataSource = bss.ListarPedidoBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que lo desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPedidoBss(IdPedidoSeleccionada);
                dataGridView1.DataSource = bss.ListarPedidoBss();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
