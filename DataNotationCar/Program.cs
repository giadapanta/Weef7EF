//Creare un'applicazione che consente di gestire Persone e relativi autovoeicoli
//Ogni persona è caratterizzata da
// Nome, Cognome, codice fiscale (chiave primaria), data di nascita
//Le automobili sono caratterizzate da:
// Targa (chiave primaria), numero posti, marca, data immatricolazione
// Realizzare il database con Entity Framework e data annotation

using DataNotationCar;
using DataNotationCar.Models;

using (var ctx = new Context())
{
    //tramite la variabile ctx richiamo il metodo ens.. che crea un db se non esiste
    ctx.Database.EnsureCreated();

    //Person p1 = new Person()
    //{
    //    CodiceFiscale = "MRRSS13A45R654W",
    //    FirstName ="Mario",
    //    LastName ="Rossi",
    //    DateOfBirth = new DateTime(1990,10,30)

    //};

    //ctx.People.Add(p1);
    //ctx.SaveChanges();
    //Console.WriteLine("INSERISCI NUOVO PROPRIETARIO");

    //var codiceFiscale = MenuConsole.GetInfo("Codice Fiscale");
    //var firstName = MenuConsole.GetInfo("Nome");
    //var lastName = MenuConsole.GetInfo("Cognome");
    //var dateOfBirth = MenuConsole.GetDate("Data di nascita");

    //Person person = new Person()
    //{
    //    CodiceFiscale = codiceFiscale,
    //    FirstName = firstName,
    //    LastName = lastName,
    //    DateOfBirth = dateOfBirth,
    //};
    //ctx.People.Add(person);
    //ctx.SaveChanges();

    //Console.WriteLine("\nINSERISCI UNA NUOVA AUTO:");
    //var plate = MenuConsole.GetInfo("targa");
    //int places = MenuConsole.GetInt("numero di posti");
    //var brand = MenuConsole.GetInfo("Brand");
    //var dateOfRegistration = MenuConsole.GetDate("Data di immatricolazione");
    //var codiceFiscale2 = MenuConsole.GetInfo("codice fiscale");
    //Car car = new Car()
    //{
    //    Places = places,
    //    Plate = plate,
    //    Brand = brand,
    //    DateOfRegistration = dateOfRegistration,
    //    CodiceFiscale = codiceFiscale2
    //};
    //ctx.Cars.Add(car);
    //ctx.SaveChanges();

    Console.WriteLine("\nI proprietari delle auto sono: ");
    foreach(var p in ctx.People)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine("\nLe auto sono:");
        foreach(var c in ctx.Cars)
    {
        Console.WriteLine(c);
    }

    //var car1 = AddCar(p1);
    //ctx.Cars.Add(car1);
    //ctx.SaveChanges();

}
//static Car AddCar(Person selectPerson)
//{
//    Car c1 = new Car()
//    {
//        Plate = "AA001AQ",
//        Places = 5,
//        Brand = "Fiat",
//        DateOfRegistration = new DateTime(2019, 01, 14),
//       Owner= selectPerson

//    };
//    return c1;
//}
