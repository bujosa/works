using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResidencial
{
   public class Residenciales
    {
        public string NombreResidencial { get; set; }
        public string Edificio { get; set; }
        public string Apartamento { get; set; }
        public string Areacomun { get; set; }
        public int MontoXApartamento { get; set; }

        public Residenciales(string NombreResidencial, string Edificio, string Apartamento, string area, int Monto)
        {
            this.NombreResidencial = NombreResidencial;
            this.Edificio = Edificio;
            this.Apartamento = Apartamento;
            Areacomun = area;
            this.MontoXApartamento = Monto;   
        }

       

       
        
    }
}
