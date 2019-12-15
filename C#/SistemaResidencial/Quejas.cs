using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResidencial
{
    class Quejas
    {
        public string queja { get; set; }
        public string NombredelResidencial { get; set; }

        public Quejas(string queja, string Nombre)
        {
            this.queja = queja;
            this.NombredelResidencial = Nombre;
        }
    }
}
