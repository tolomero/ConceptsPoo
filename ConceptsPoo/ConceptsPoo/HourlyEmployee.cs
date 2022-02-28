namespace ConceptsPoo
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }
        public override string ToString()
        //para que salga en otra linea se pone \n y con un tabulador \t
        //y P2 es formato de Porcentaje con 2 decimales
        {
            return $"{base.ToString()}" +
                $"\n\t Hours..................: {$"{Hours:N2}",20}" +
                $"\n\t HourValue..............: {$"{HourValue:C2}",20}" +
                $"\n\t Value to pay...........: {$"{GetValueToPay():C2}",20}";
        }
    }
}
