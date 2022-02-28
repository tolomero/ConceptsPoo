namespace ConceptsPoo
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }
        public override string ToString()
        //para que salga en otra linea se pone \n y con un tabulador \t
        //y P2 es formato de Porcentaje con 2 decimales
        {
            return $"{base.ToString()}" +
                $"\n\t Base................: {$"{Base:N2}",20}";
        }
    }

}
