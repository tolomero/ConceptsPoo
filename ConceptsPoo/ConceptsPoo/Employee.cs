namespace ConceptsPoo
{
    public abstract class Employee
    {
        // para crear propiedades con el snipet prop y se crea la propiedad 
        // se le pone el camelcase para identificar el atributo parametro del metodo
        // pero esto ya casi no se usa por quecon get y set se obvia tenr el atributo privado
        //private   string _fistName{ get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HirirngDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValueTopay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}, " +
                $"Birthday:{BirthDate}, " +
                $"Hiring:{HirirngDate}, " +
                $"Is Active: {IsActive}";
        }
    }
}
