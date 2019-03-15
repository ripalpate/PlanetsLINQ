using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            //`Add()` Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //Create another `List` that contains that last two planet of our solar system.
            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };

            //Combine the two lists by using `AddRange()`.
            planetList.AddRange(lastPlanets);

            //Use `Insert()` to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            //Use `Add()` again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            //Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            //Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.
            planetList.Remove("Pluto");


            var solarSystemProbes = new Dictionary<string, List<string>>();

            solarSystemProbes.Add("Mariner", new List<string> { "Mercury", "Venus", "Earth" });
            solarSystemProbes.Add("Messanger", new List<string> { "Mercury" });
            solarSystemProbes.Add("Vanera", new List<string> { "Venus" });
            solarSystemProbes.Add("Viking", new List<string> { "Mars" });
            solarSystemProbes.Add("Opportunity", new List<string> { "Mars" });
            solarSystemProbes.Add("Curiosity", new List<string> { "Mars" });
            solarSystemProbes.Add("Pioneer", new List<string> { "Jupiter", "Saturn", "Earth" });
            solarSystemProbes.Add("Voyager", new List<string> { "Jupiter", "Saturn", "Uranus", "Neptune" });


            for (var i = 0; i < planetList.Count; i++)
            {
                var ListOfProbes = solarSystemProbes.Where(listOfPlanets => listOfPlanets.Value.Contains(planetList[i])).Select(probe => probe.Key);

                var planetWithProbes = planetList[i] + " : ";
                foreach (var probe in ListOfProbes)
                {
                    planetWithProbes += " " + probe + ",";

                }
                Console.WriteLine(planetWithProbes.TrimEnd(','));
            }

            Console.ReadLine();
        }
    }
}
