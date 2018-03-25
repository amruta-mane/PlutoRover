using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRover
{
    public class Rover
    {
        private Grid grid;
        public RoverLocation currentPosition;

        public Rover(Grid grid)
        {
            this.grid = grid;
        }

        public RoverLocation MoveRover(string moveCommand)
        {
            foreach (char move in moveCommand)
            {
                switch (move)
                {
                    case 'F':
                        grid.MoveForward(currentPosition);
                        break;
                    case 'B':
                        grid.MoveBackward(currentPosition);
                        break;
                    case 'R':
                        grid.MoveRight(currentPosition);
                        break;
                    case 'L':
                        grid.MoveLeft(currentPosition);
                        break;
                    default:
                        Console.WriteLine($"Move '{move}' is not a valid move.");
                        break;
                }
            }

            return currentPosition;
        }
    }
}
