using GestorTareasWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestorTareas_juabascar
{
    public partial class Form1 : Form
    {

        /// Lista interna de tareas.
        /// </summary>
        private List<TaskItem> tareas = new List<TaskItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la tarea no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TaskItem nuevaTarea = new TaskItem
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                FechaVencimiento = dtpVencimiento.Value,
                Completada = false,
                Categoria = cmbCategoria.SelectedItem?.ToString(),
                PrioridadAlta = chkPrioridadAlta.Checked
            };

            tareas.Add(nuevaTarea);
            ActualizarLista();

            // Limpiar campos
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex >= 0)
            {
                tareas.RemoveAt(lstTareas.SelectedIndex);
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona una tarea antes de eliminar");
            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex >= 0)
            {
                tareas[lstTareas.SelectedIndex].Completada = true;
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona una tarea antes de marcar como completada");
            }
        }

        private void ActualizarLista()
        {
            lstTareas.Items.Clear();
            foreach (var tarea in tareas)
            {
                lstTareas.Items.Add(tarea);
            }

            lblContadorTareas.Text = $"Tareas: {tareas.Count}";

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
