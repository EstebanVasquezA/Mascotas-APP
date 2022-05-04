using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mascotas_APP.Models
{
    public partial class Raza
    {
        public RestRequest request { get; set; }

        const string mimetype = "application/json";
        const string contentType = "Content-Type";
        public Raza()
        {
            Mascota = new HashSet<Mascota>();
            request = new RestRequest();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Mascota> Mascota { get; set; }
    }
}
