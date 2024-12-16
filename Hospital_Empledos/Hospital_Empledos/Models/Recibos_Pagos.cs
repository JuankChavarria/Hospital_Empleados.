using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empledos.Models
{
    public class Recibos_Pagos
    {
        public int IdReciboPago { get; set; }
        public int IdNomina { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Detalles { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
        public Recibos_Pagos() { }

        public Recibos_Pagos(int idReciboPago, int idNomina, int idEmpleado, DateTime fechaEmision, string detalles, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdReciboPago = idReciboPago;
            IdNomina = idNomina;
            IdEmpleado = idEmpleado;
            FechaEmision = fechaEmision;
            Detalles = detalles;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}