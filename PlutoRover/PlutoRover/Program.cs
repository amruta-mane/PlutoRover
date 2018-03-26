using System;
using System.Collections.Generic;
/// <summary>
/// Main Class for Pluto Rover
/// </summary>
namespace PlutoRover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ObstacleCoOrdinates> obstacles = new List<ObstacleCoOrdinates> { new ObstacleCoOrdinates(1, 1) };

            Console.WriteLine("Get ready to maneuver the rover on Pluto!");
            InsertBlankLine();

            // XX TODO Get input from user for the grid
            Rover rover = new Rover(new Grid(100, 100, obstacles));
            rover.currentPosition = new RoverLocation(0, 0, Direction.N);

            bool confirmed = false;
            do
            {
                Console.WriteLine("Input maneuver instructions");
                string instruction = Console.ReadLine();

                ObstacleCoOrdinates obstacleCo;
                RoverLocation location = rover.MoveRover(instruction, out obstacleCo);

                if (obstacleCo.XCoOrdinate != 0 && obstacleCo.YCoOrdinate != 0)
                {
                    Console.WriteLine($"Obstacle at '{obstacleCo.XCoOrdinate}, {obstacleCo.YCoOrdinate}'. Rover's current location : {location.CurrentX},{location.CurrentY},{location.CurrentDirection}");
                }
                else
                {
                    Console.WriteLine($"Rover's current location : {location.CurrentX},{location.CurrentY},{location.CurrentDirection}");
                }

                Console.WriteLine("Do you want to continue to move the rover [y/n]");

                string option = Console.ReadLine();
                confirmed = option == "y" ? true : false;
                
            } while (confirmed);

            Console.WriteLine("Press Any Key To exit.");

            Console.ReadKey();
        }

        private static void InsertBlankLine()
        {
            Console.WriteLine("");
        }
    }

    public enum Direction
    {
        N, E, S, W
    };
}
