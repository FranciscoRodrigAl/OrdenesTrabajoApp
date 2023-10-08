using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesTrabajoApp.Models
{
    public class OrdenTrabajo
    {
        public int Id { get; set; }
        public string Descripcion { get;set; }
        public DateTime fechaCreacion { get; set; }
        public string Estado { get; set; }
        public DateTime fechaResolucion { get; set; }
        public string Prioridad { get; set; }
        public string Informador { get; set; }
        public string? Responsable { get; set; }
    }
}
