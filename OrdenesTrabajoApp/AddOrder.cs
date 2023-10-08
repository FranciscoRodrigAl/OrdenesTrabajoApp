using OrdenesTrabajoApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenesTrabajoApp
{
    public partial class Agregar : Form
    {
        public event Action<OrdenTrabajo> AgregarOrden;
        Random r = new Random();
        public Agregar()
        {
            InitializeComponent();
            Console.WriteLine("opened");
            cbxEstado.SelectedIndex = 0;
            cbxPrioridad.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OrdenTrabajo orden = new OrdenTrabajo();
            int id = r.Next(1, 999999);
            string descripcion = tbDescripcion.Text;
            DateTime creacion = datePickerCreacion.Value.Date;
            string estado = cbxEstado.GetItemText(cbxEstado.SelectedItem);
            DateTime resolucion = datePickerResolucion.Value.Date;
            string prioridad = cbxPrioridad.GetItemText(cbxPrioridad.SelectedItem);
            string informador = tbInformador.Text;
            string responsable = tbResponsable.Text;

            orden.Id = id;
            orden.Descripcion = descripcion;
            orden.fechaCreacion = creacion;
            orden.Estado = estado;
            orden.fechaResolucion = resolucion;
            orden.Prioridad = prioridad;
            orden.Informador = informador;
            orden.Responsable = responsable;

            AgregarOrden.Invoke(orden);
        }
    }
}
