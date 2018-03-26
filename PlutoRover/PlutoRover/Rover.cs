using System;

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

        public RoverLocation MoveRover(string moveCommand, out ObstacleCoOrdinates obstacleCoOrdinates)
        {
            bool obstacleHit = false;
            obstacleCoOrdinates = new ObstacleCoOrdinates();

            foreach (char move in moveCommand)
            {
                switch (move)
                {
                    case 'F':
                        obstacleHit = grid.MoveForward(currentPosition, out obstacleCoOrdinates);
                        break;
                    case 'B':
                        obstacleHit = grid.MoveBackward(currentPosition, out obstacleCoOrdinates);
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
                
                if (obstacleHit)
                {
                    break;
                }
            }

            return currentPosition;
        }
    }
}
