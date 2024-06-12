using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Trabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxTipo.Items.Add("Débito");
            comboBoxTipo.Items.Add("Crédito");
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = textBoxDescripcion.Text;
            decimal monto;
            if (!decimal.TryParse(textBoxMonto.Text, out monto))
            {
                MessageBox.Show("Por favor ingrese un monto válido.");
                return;
            }
            string tipo = comboBoxTipo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            if (tipo == "Débito")
            {
                dataGridView1.Rows.Add(descripcion, monto, null);
            }
            else
            {
                dataGridView1.Rows.Add(descripcion, null, monto);
            }

            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }

                
            }
        }
    }
}


