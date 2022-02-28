using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPoo
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }
        // como no podemos operar con un decimal y un flaot nos toca ponerle (decimal para poder hacer la operación)
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }
        public override string ToString()
        //para que salga en otra linea se pone \n y con un tabulador \t
        //y P2 es formato de Porcentaje con 2 decimales
        {
            return $"{base.ToString()}" +
                $"\n\t Commision Percentaje: {$"{CommissionPercentaje:P2}", 20}" +
                $"\n\t Ventas..............: {$"{Sales:C2}", 20}" +
                $"\n\t Value to pay........: {$"{GetValueToPay():C2}", 20}";
        }
    }
}
