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

//Console.WriteLine(employee1); 

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

//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Juan",
    LastName = "Hernandez",
    BirthDate = new Date(2000, 7, 11),
    HirirngDate = new Date(2021, 8, 15),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F

};

//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Bertha",
    LastName = "Aguilar",
    BirthDate = new Date(1950, 10, 11),
    HirirngDate = new Date(2021, 9, 12),
    IsActive = true,
    Base = 860678.56M, 
    Sales = 58000000M,
    CommissionPercentaje = 0.015F

};

//Console.WriteLine(employee4);

//se escribe la I para decir que va a ser una interfas se puede usar con Add o directamente con {Employee1,Employee2}
ICollection<Employee> employees = new List<Employee>()
{
    employee1,employee2,employee3,employee4
};

decimal payroll = 0;
foreach(Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
 
Console.WriteLine("                                ===================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",20}");

Invoice invoice1 = new Invoice()
{
    Description = "iphone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Carne",
    Id = 222,
    Price = 8000M,
    Quantity =  17.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);

//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);
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
