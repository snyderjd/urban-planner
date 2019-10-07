using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
        // Build Your City
        // 1. Create several buildings in the Main() method of Program.cs.
        //      Ex: Building FiveOneTwoEigth = new Building("512 8th Avenue");
        // 2. Give each building a width, depth, and number of stories.
        // 3. Construct each building.
        // 4. Have business people in your city purchase each of your buildings.

        // After all of the buildings have been purchased, display the following information to the console for each building.

            Building FiveOneTwoEight = new Building("512 8th Avenue") {
                Stories = 10,
                Width = 20,
                Depth = 20
            };

            FiveOneTwoEight.Construct();
            FiveOneTwoEight.Purchase("Bob Ross");

            Building NSS = new Building("301 Plus Park Blvd") {
                Stories = 5,
                Width = 40,
                Depth = 30,
            };

            NSS.Construct();
            NSS.Purchase("John Wark");

            Building AllianceBernstein = new Building("510 Broadway") {
                Stories = 25,
                Width = 50,
                Depth = 50
            };

            AllianceBernstein.Construct();
            AllianceBernstein.Purchase("Alliance Bernstein");

            List<Building> buildings = new List<Building>() {
                FiveOneTwoEight, NSS, AllianceBernstein
            };

            foreach(Building building in buildings)
            {
                Console.WriteLine(building.GetAddress());
                Console.WriteLine("--------------------");
                Console.WriteLine($"Designed by {building.GetDesigner()}.");
                Console.WriteLine($"Constructed on {building.GetDateConstructed()}.");
                Console.WriteLine($"Owned by {building.GetOwner()}");
                Console.WriteLine($"{building.Volume} cubic meters of space.");
                Console.WriteLine();

            }


        }
    }
}
