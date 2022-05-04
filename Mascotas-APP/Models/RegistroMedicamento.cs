using System;
using System.Collections.Generic;
using System.Text;

namespace Mascotas_APP.Models
{
    public partial class RegistroMedicamento
    {
        public DateTime Fecha { get; set; }
        public int Medicamento { get; set; }
        public int Mascota { get; set; }
        public int Veterinario { get; set; }

        public virtual Mascota MascotaNavigation { get; set; }
        public virtual Medicamento MedicamentoNavigation { get; set; }
        public virtual Veterinario VeterinarioNavigation { get; set; }
    }
}
