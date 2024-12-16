﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empledos.Models
{
    public class Incidente
    {
        public int IdIncidente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;

        public Incidente() { }

        public Incidente(int idIncidente, int idEmpleado, DateTime fecha, string tipo, string descripcion, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdIncidente = idIncidente;
            IdEmpleado = idEmpleado;
            Fecha = fecha;
            Tipo = tipo;
            Descripcion = descripcion;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}