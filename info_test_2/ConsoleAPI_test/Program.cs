using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MainClass;

namespace ConsoleAPI_test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                var menu = new EasyConsole.Menu()
                 .Add("Basics - Get Departure/Arrivals of an Airport (JFK)", () => {
                     CodeClass cc = new CodeClass();
                     Console.WriteLine(cc.getJson("LIST", "JFK", "departure"));
                 })
                 .Add("Basics - Get Full name from IATA/ICAO JFK for Example", () => {
                     CodeClass cc = new CodeClass();
                     Console.WriteLine(cc.getJson("IATA", "JFK", ""));
                 })
                 .Add("Basics - Get flight departures from airport name (JFK)", () => {
                     CodeClass cc = new CodeClass();
                     Console.WriteLine(cc.getJson("LOCATION", "JFK", "departure"));
                 })
                 .Add("Basics - Get flight arrival from airport name (JFK)", () => {
                     CodeClass cc = new CodeClass();
                     Console.WriteLine(cc.getJson("LOCATION", "JFK", "arrival"));
                 })
                 .Add("Advance- Use 2 airport (ATL - ORD) and airline to get flight (RT)", () => {
                     CodeClass cc = new CodeClass();
                     Console.WriteLine(cc.getJson("TRACKER", "", ""));
                 })
                .Add("Exit", () => {
                    exit = true;
                 });
                menu.Display();
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();
        }
    }
}
