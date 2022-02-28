//#4 se improta
using ConceptsPoo;

Console.WriteLine("Hello, World!");
Console.WriteLine("==============");

// primero utilizamos la clase abstracta o
// interfas pero cuando utilizo el new que es el constructor le especifico de que clase de empleado es: 
//a los decimales le ponemos la M para identificar valor monelda y a la float la F.
Employee employee1 = new SalaryEmployee()
{
    Id = 1210,
    FirstName = "Tolo",
    LastName = "Romero",
    BirthDate = new Date(1987, 5, 23),
    HirirngDate = new Date(2022, 1, 23),
    IsActive = true,
    Salary = 18000000.45M

};

Console.WriteLine(employee1); 

Employee employee2 = new CommissionEmployee()
{
    Id = 2216,
    FirstName = "Lina",
    LastName = "Gongora",
    BirthDate = new Date(2000, 7, 11),
    HirirngDate = new Date(2021, 8, 15),
    IsActive = true,
    Sales   = 320000000M,
    CommissionPercentaje = 0.03F

};

Console.WriteLine(employee2);

//#5 se llama la clase Date que creamos
//Date? date1 = new Date(2022,2,25);

//esto no sirve por que necesito una sobre escritura
//Console.WriteLine(date1.ToString());
//Console.WriteLine(date1);
//para sacar el try catch que encierre lo que quiero es con control + ks luego escriba try
//try
//{
//    //#5 se llama la clase Date que creamos pARA QUE NO MUESTRE  LA BASE DE LA CLASE Y SOLO LLAME LO QUE NECESITAMOS toca ponerle el to string con overrride
//    Console.WriteLine(new Date(1986, 5, 17));
//    Console.WriteLine(new Date(2024, 2, 29));
//    Console.WriteLine(new Date(2000, 9, 30));
//}
//catch (Exception error)
//{

//    Console.WriteLine(error.Message);
//}
