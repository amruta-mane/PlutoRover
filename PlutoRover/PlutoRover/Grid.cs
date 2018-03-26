using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Class for grid tracking and any movements
/// </summary>
namespace PlutoRover
{
    public class Grid
    {
        #region private variables

        private int x;
        private int y;

        private LinkedList<Direction> directionsList;
        private LinkedList<int> xAxis = new LinkedList<int>();
        private LinkedList<int> yAxis= new LinkedList<int>();

        private List<ObstacleCoOrdinates> obstaclesList = new List<ObstacleCoOrdinates>();

        #endregion

        #region Properties

        public int MaxXCoOrdinate
        {
            get
            {
                return x;
            }

            private set { }
        }
        public int MaxYCoOrdinate
        {
            get
            {
                return y;
            }

            private set { }
        }

        #endregion

        #region Constructor

        public Grid(int x, int y, List<ObstacleCoOrdinates> obstacles)
        {
            this.x = x;
            this.y = y;
            this.obstaclesList = obstacles;

            Direction[] directions = { Direction.N, Direction.E, Direction.S, Direction.W };
            directionsList = new LinkedList<Direction>(directions);

            InitializeAxis(x, ref xAxis);
            InitializeAxis(y, ref yAxis);            
        }

        #endregion

        #region Grid Move Methods

        public bool MoveForward(RoverLocation location, out ObstacleCoOrdinates obstacle)
        {
            RoverLocation newLocation = new RoverLocation(location.CurrentX, location.CurrentY, location.CurrentDirection);
            obstacle = new ObstacleCoOrdinates();

            switch (location.CurrentDirection)
            {
                case Direction.N:
                    newLocation.CurrentX = IncrementX(location.CurrentX);
                    break;
                case Direction.S:
                    newLocation.CurrentX = DecrementX(location.CurrentX);
                    break;
                case Direction.E:
                    newLocation.CurrentY = IncrementY(location.CurrentY);
                    break;
                case Direction.W:
                    newLocation.CurrentY = DecrementY(location.CurrentY);
                    break;
            }

            bool obstacleAtNewLocation = CheckIfObstacleAtLocation(newLocation.CurrentX, newLocation.CurrentY);

            if (obstacleAtNewLocation)
            {
                obstacle.XCoOrdinate = newLocation.CurrentX;
                obstacle.YCoOrdinate = newLocation.CurrentY;
                return true;
            }
            else
            {
                location.CurrentX = newLocation.CurrentX;
                location.CurrentY = newLocation.CurrentY;
                location.CurrentDirection = newLocation.CurrentDirection;

                return false;
            }
        }

        public bool MoveBackward(RoverLocation location, out ObstacleCoOrdinates obstacle)
        {
            RoverLocation newLocation = new RoverLocation(location.CurrentX, location.CurrentY, location.CurrentDirection);
            obstacle = new ObstacleCoOrdinates();

            switch (location.CurrentDirection)
            {
                case Direction.N:
                    newLocation.CurrentX = DecrementX(location.CurrentX);
                    break;
                case Direction.S:
                    newLocation.CurrentX = IncrementX(location.CurrentX);
                    break;
                case Direction.E:
                    newLocation.CurrentY = DecrementY(location.CurrentY);
                    break;
                case Direction.W:
                    newLocation.CurrentY = IncrementY(location.CurrentY);
                    break;
            }

            bool obstacleAtNewLocation = CheckIfObstacleAtLocation(newLocation.CurrentX, newLocation.CurrentY);

            if(obstacleAtNewLocation)
            {
                obstacle.XCoOrdinate = newLocation.CurrentX;
                obstacle.YCoOrdinate = newLocation.CurrentY;
                return true;
            }
            else
            {
                obstacle = new ObstacleCoOrdinates();
                location.CurrentX = newLocation.CurrentX;
                location.CurrentY = newLocation.CurrentY;
                location.CurrentDirection = newLocation.CurrentDirection;
                return false;
            }
        }

        public void MoveRight(RoverLocation location)
        {
            LinkedListNode<Direction> node = directionsList.Find(location.CurrentDirection);

            // If last node go to first node 
            if (directionsList.Last() == node.Value)
            {
                location.CurrentDirection = directionsList.First.Value;
            }
            else
            {
                location.CurrentDirection = node.Next.Value;
            }
        }

        public void MoveLeft(RoverLocation location)
        {
            LinkedListNode<Direction> node = directionsList.Find(location.CurrentDirection);

            // If first node go to last node
            if (directionsList.First() == node.Value)
            {
                location.CurrentDirection = directionsList.Last.Value;
            }
            else
            {
                location.CurrentDirection = node.Previous.Value;
            }
        }

        #endregion

        #region private methods
        private int IncrementX(int x)
        {
            LinkedListNode<int> node = xAxis.Find(x);

            // If last node go to first 
            if (xAxis.Last() == node.Value)
            {
                x = xAxis.First.Value;
            }
            else
            {
                x = node.Next.Value;
            }

            return x;
        }

        private int DecrementX(int x)
        {
            LinkedListNode<int> node = xAxis.Find(x);

            // If first node go to last
            if (xAxis.First() == node.Value)
            {
                x = xAxis.Last.Value;
            }
            else
            {
                x = node.Previous.Value;
            }

            return x;
        }

        private int IncrementY(int y)
        {
            LinkedListNode<int> node = yAxis.Find(y);

            // If last node go to first 
            if (yAxis.Last() == node.Value)
            {
                y = yAxis.First.Value;
            }
            else
            {
                y = node.Next.Value;
            }

            return y;
        }

        private int DecrementY(int y)
        {
            LinkedListNode<int> node = yAxis.Find(y);

            // If first node go to last 
            if (yAxis.First() == node.Value)
            {
                y = yAxis.Last.Value;
            }
            else
            {
                y = node.Previous.Value;
            }

            return y;
        }

        private bool CheckIfObstacleAtLocation(int x, int y)
        {
            if (obstaclesList.Any(o => o.XCoOrdinate == x && o.YCoOrdinate == y))
            {
                return true;
            }

            return false;
        }

        private void InitializeAxis(int length, ref LinkedList<int> axis)
        {
            List<int> axisList = new List<int>();
            for (int i = 0; i <= x; i++)
            {
                axisList.Add(i);
            }

            axis = new LinkedList<int>(axisList);
        }

        #endregion
    }
}