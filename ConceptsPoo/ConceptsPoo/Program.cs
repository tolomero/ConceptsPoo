using ConceptsPoo;

Console.WriteLine("Hello, World!");
Console.WriteLine("==============");

//Date? date1 = new Date(2022,2,25);

//esto no sirve por que necesito una sobre escritura
//Console.WriteLine(date1.ToString());
//Console.WriteLine(date1);
//para sacar el try catch que encierre lo que quiero es con control + ks luego escriba try
try
{
    Console.WriteLine(new Date(1986, 5, 17));
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2000, 9, 30));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}
