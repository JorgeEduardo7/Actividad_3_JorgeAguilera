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
    public partial class ClienteInterfaz : Form
    {
        public ClienteInterfaz()
        {
            InitializeComponent();
        }
        ClienteBSS bss = new ClienteBSS();
        private void ClienteInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente p = new Cliente();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.CorreoElectronico = textBox4.Text;
            p.Direccion = textBox5.Text;

            bss.InsertarClienteBss(p);
            MessageBox.Show("Se guardó correctamente");

            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Cliente editarCliente = bss.ObtenerClienteIdBss(IdClienteSeleccionada);
            editarCliente.Nombre = textBox1.Text;
            editarCliente.Apellido = textBox2.Text;
            editarCliente.Telefono = textBox3.Text;
            editarCliente.CorreoElectronico = textBox4.Text;
            editarCliente.Direccion = textBox5.Text;

            bss.EditarClienteBss(editarCliente);
            MessageBox.Show("Datos Actualizados");


            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a este Cliente?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdClienteSeleccionada);
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteDatos fr = new ClienteDatos(IdClienteSeleccionada);
            fr.ShowDialog();
            bss.ClienteDatosBSS(IdClienteSeleccionada);
            bss.ClienteDatosBSS2(IdClienteSeleccionada);
            bss.ClienteDatosBSS3(IdClienteSeleccionada);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
