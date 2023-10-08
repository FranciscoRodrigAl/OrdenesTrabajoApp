using OrdenesTrabajoApp.Models;
using System.ComponentModel;

namespace OrdenesTrabajoApp
{
    public partial class Form1 : Form
    {
        private Agregar formAgregar = null;

        private BindingList<OrdenTrabajo> ordenes = new BindingList<OrdenTrabajo>();
        public Form1()
        {
            InitializeComponent();
            addExampleElements();
            dataGridView1.DataSource = ordenes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (formAgregar == null || formAgregar.IsDisposed)
            {
                Agregar formAgregar = new Agregar();

                formAgregar.AgregarOrden += (data) =>
                {
                    //MessageBox.Show($"nueva orden {data.Descripcion}");
                    ordenes.Add(data);
                    formAgregar.Close();
                };
                formAgregar.Show();
            }
            else
            {
                formAgregar.BringToFront();
            }



        }

        private void RefreshOrdenes()
        {
            dataGridView1.DataSource = ordenes;
        }

        private void addExampleElements()
        {
            var orden1 = new OrdenTrabajo
            {
                Id = 1,
                Descripcion = "Reparar equipo con problemas",
                fechaCreacion = DateTime.Now.Date,
                Estado = "En progreso",
                fechaResolucion = DateTime.Now.AddDays(3).Date,
                Prioridad = "Alta",
                Informador = "John Doe",
                Responsable = "Alice Smith"
            };

            var orden2 = new OrdenTrabajo
            {
                Id = 2,
                Descripcion = "Instalar new software",
                fechaCreacion = DateTime.Now.Date,
                Estado = "Pendiente",
                fechaResolucion = DateTime.Now.AddDays(5).Date,
                Prioridad = "Media",
                Informador = "Alice Smith",
                Responsable = null // No responsable assigned yet
            };

            ordenes.Add(orden1);
            ordenes.Add(orden2);
        }
    }
}