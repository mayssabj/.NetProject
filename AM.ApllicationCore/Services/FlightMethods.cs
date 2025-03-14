using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AM.ApllicationCore.Domain;
using AM.ApllicationCore.Interfaces;

namespace AM.ApllicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight> { };
        //question16
        public Action<Domain.Plane> FlightDetailsDel;
        public Func<string, float> DurationAverageDel;
        public FlightMethods()
        {
            //FlightDetailsDel= ShowFlightDetails;
            //DurationAverageDel= DurationAverage;
            FlightDetailsDel = p =>
            {
                var query = from flight in Flights
                            where flight.MyPlane == p
                            select flight;
                foreach (var item in query)
                {
                    Console.WriteLine(item.FlightDate + item.Destination);
                }
            };
            DurationAverageDel = d =>
            {
                var query = from flight in Flights
                            where flight.Destination == d
                            select flight.EstimatedDuration;
                return query.Average();
            };
        }


        public IList<DateTime> GetFlightDates(string destination)
        {
            //IList<DateTime> dates = new List<DateTime> { };

            ////foreach (var flight in Flights) {
            ////    if (flight.Destination.Equals(destination))
            ////  {
            ////        dates.Add(flight.FlightDate);
            ////    }
            ////}
            //////for (int i = 0; i < Flights.Count; i++)
            //////{
            //////    if (Flights[i].Destination.Equals(destination))
            //////    {
            //////        dates.Add(Flights[i].FlightDate);
            //////    }
            //////}
            ////return dates;

            ///***Q9***/
            //var query = from f in Flights
            //            where f.Destination == destination
            //            select f.FlightDate;
            //return query.ToList();

            //-------Question 19 rendre tt avec lamdba
            var lambdaquery = Flights
               .Where(f => f.Destination == destination)
               .Select(f => f.FlightDate);
            return lambdaquery.ToList();

        }

        public void GetFlights(string filterType, string filterValue)
        {

            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination.Equals(filterValue))
                            Console.WriteLine(flight);
                    }
                    break;
                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate == DateTime.Parse(filterType))
                            Console.WriteLine(flight);
                    }
                    break;
                case "EstimationDuration":
                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedDuration == float.Parse(filterType))
                            Console.WriteLine(flight);
                    }
                    break;
                case "Departure":
                    foreach (var flight in Flights)
                    {
                        if (flight.Departure.Equals(filterType))
                            Console.WriteLine(flight);
                    }
                    break;
                case "EffectiveArrival":
                    foreach (var flight in Flights)
                    {
                        if (flight.EffectiveArrival == DateTime.Parse(filterType))
                            Console.WriteLine(flight);
                    }
                    break;
            }




        }


        public void ShowFlightDetails(Domain.Plane plane)
        {
            //var query = from flight in Flights
            //            where flight.MyPlane == plane
            //            select flight;
            //foreach (var item in query) {  
            //    Console.WriteLine(item.FlightDate+ item.Destination);
            //}

            //question 19 
            var lambdaquery = Flights
                .Where(f => f.MyPlane == plane)
                .Select(f => f);
            foreach (var item in lambdaquery)
            {
                Console.WriteLine(item.FlightDate + item.Destination);
            }
        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            /**methode1*/
            //var query = from flight in Flights
            //            where DateTime.Compare(flight.FlightDate, startDate) >= 0
            //            && (flight.FlightDate - startDate).TotalDays < 7
            //            select flight;
            //return query.Count();
            /**methode2*/
            //var query = from flight in Flights
            //            where flight.FlightDate >= startDate
            //            && flight.FlightDate < startDate.AddDays(7)
            //            select flight;
            //return query.Count();

            //Question 19
            var lambdaquery = Flights
                .Where(f => f.FlightDate >= startDate && f.FlightDate < startDate.AddDays(7));
            return lambdaquery.Count();
        }

        public float DurationAverage(string destination)
        {
            //var query = from flight in Flights
            //            where flight.Destination == destination
            //            select flight.EstimatedDuration;
            //return query.Average();

            //Question19
            var lambdaquery = Flights
                .Where(f => f.Destination == destination)
                .Select(f => f.EstimatedDuration);
            return lambdaquery.Average();
        }

        public IList<Flight> OrderedDurationFlights()
        {
            //var query = from flight in Flights
            //            orderby flight.EstimatedDuration descending
            //            select flight;

            //return query.ToList();

            //Question19
            var lambdaquery = Flights
                .OrderByDescending(f => f.EstimatedDuration);
            return lambdaquery.ToList();
        }

        //public IList<Traveller> SeniorTravellers(Flight flight)
        //{
        //    //var query = from p in flight.ListPassengers.OfType<Traveller>()
        //    //            orderby p.BirthDate ascending 
        //    //            select p;

        //    // return query.Take(3).ToList();

        //    //Question19
        //    var lambdaquery = flight.ListPassengers.OfType<Traveller>()
        //         .OrderBy(f => f.BirthDate);
        //    return lambdaquery.ToList();

        //}

        public void DestinationGroupedFlights()
        {
            //var query = from flight in Flights
            //            group flight by flight.Destination;
            //foreach (var g in query)
            //{
            //    Console.WriteLine("destination :" +g.Key);
            //    foreach(var f in g)
            //    {
            //        Console.WriteLine("decollage :" + f.FlightDate);
            //    }
            //} 

            //Question19
            var lambdaquery = Flights
                .GroupBy(f => f.Destination);
            foreach (var g in lambdaquery)
            {
                Console.WriteLine("destination :" + g.Key);
                foreach (var f in g)
                {
                    Console.WriteLine("decollage :" + f.FlightDate);
                }

            }
        }
    }
} 
