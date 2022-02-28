namespace ConceptsPoo
//para heredar se ponen lo dos puntos :
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;
        }
        public override string ToString()
        //para que salga en otra linea se pone \n y con un tabulador \t
        //y C2 es formato de numero currenci con 2 decimales
        //para interpolar dos veces se hace corchetes pesos "" y el numero 15 es que me ocupe 15 p[ociciones asi tenga el valor que sea
        {
            return $"{base.ToString()}" +
                $"\n\t Value to pay.........: {$"{GetValueToPay():C2}",  20}";
        }
    }
}
