using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mascotas_APP.Models
{
    public partial class Mascota
    {
        public RestRequest request { get; set; }

        const string mimetype = "application/json";
        const string contentType = "Content-Type";

        public Mascota()
        {
            request = new RestRequest();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public double? Peso { get; set; }
        public int TipoMascota { get; set; }
        public int Raza { get; set; }

        public virtual Raza RazaNavigation { get; set; }
        public virtual TipoMascota TipoMascotaNavigation { get; set; }
    }
}
