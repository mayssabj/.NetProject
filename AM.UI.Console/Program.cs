using AM.ApllicationCore;
using AM.ApllicationCore.Domain;
using AM.ApllicationCore.Services;

//Plane plane1 = new Plane();
//plane1.Capacity = 100;
//plane1.ManufactureDate = new DateTime(2024,05,23);
//plane1.PlaneType= PlaneType.Airbus;
//plane1.PlaneId = 1;
//Console.WriteLine(plane1.ToString());
//Plane plane2 = new Plane(PlaneType.Airbus , 200, DateTime.Now);
//Console.WriteLine(plane2.ToString());

Plane plane3= new Plane {ManufactureDate=DateTime.Now,
    Capacity=150, 
    PlaneId=3 };
Console.WriteLine(plane3.ToString());

Plane plane4 = new Plane { };
Console.WriteLine(plane4.ToString());

Passenger passenger= new Passenger {
    FullName = new FullName
    {
        FirstName = "benjoud",
        LastName = "mayssa"
    }, 
    EmailAddress="mayssa.benjoud@esprit.tn"};
Console.WriteLine("--------avant extenstion----------");
Console.WriteLine(passenger.ToString());

Console.WriteLine("--------apres extenstion------------");
passenger.UpperFullName();
Console.WriteLine(passenger.ToString());

Console.WriteLine(passenger.CheckProfile("BenJoud", "Mayssa"));
Console.WriteLine(passenger.CheckProfile("benjoud", "meriem"));
Console.WriteLine(passenger.CheckProfile("benjoud", "meriem", "Mayssa.benjoud@esprit.tn"));

Staff staff1 = new Staff { 
    FullName= new FullName
    {
        FirstName = "staffName",
        LastName = "LastNamestaff"
    }
};
Traveller traveller1 = new Traveller {
    Nationality = "Tunisian",
    FullName = new FullName { FirstName = "FirstNameTraveller" }
};

passenger.PassengerType();
staff1.PassengerType();
traveller1.PassengerType();

/***Atelier2*/// 
/**Q5**/
Console.WriteLine("--------exercice atelier 2-----------------");
FlightMethods flightMethods = new FlightMethods { 
    Flights = TestData.listFlights
};

Console.WriteLine("----------question6/7----------------");
foreach (var item in flightMethods.GetFlightDates("Madrid")){
    Console.WriteLine(item);
}

Console.WriteLine("------------question8----------------");
flightMethods.GetFlights("Destination", "Paris");

Console.WriteLine("-------------question10---------------");
flightMethods.ShowFlightDetails(TestData.Airbusplane);

Console.WriteLine("--------------Question11-----------------");
Console.WriteLine(flightMethods.ProgrammedFlightNumber(new DateTime(2022, 02, 01, 21, 10, 10)));

Console.WriteLine("Question12");
Console.WriteLine(flightMethods.DurationAverage("Paris"));

Console.WriteLine("-------------Question13---------------");
foreach (var item in flightMethods.OrderedDurationFlights())
{
    Console.WriteLine(item);
}

//Console.WriteLine("-------------Question14----------------------");
//foreach (var item in flightMethods.SeniorTravellers(TestData.flight1))
//{
//    Console.WriteLine(item);
//}

Console.WriteLine("-----------Question15-------------------------");
flightMethods.DestinationGroupedFlights();

Console.WriteLine("-----------Question16 sans delegate-------------");
flightMethods.ShowFlightDetails(TestData.Airbusplane);

Console.WriteLine("-----------Question16 avec delegate----------");
flightMethods.FlightDetailsDel(TestData.Airbusplane);

Console.WriteLine("-----------Atelier 3----------");
AMContext context = new AMContext();
//context.Flights.Add(TestData.flight2);
//context.SaveChanges();
Console.WriteLine(context.Flights.First().MyPlane.Capacity);

