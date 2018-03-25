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

        public Grid(int x, int y)
        {
            this.x = x;
            this.y = y;

            Direction[] directions = { Direction.N, Direction.E, Direction.S, Direction.W };
            directionsList = new LinkedList<Direction>(directions);
        }

        #endregion

        #region Grid Move Methods

        public void MoveForward(RoverLocation location)
        {
            switch (location.CurrentDirection)
            {
                case Direction.N:
                    location.CurrentX = IncrementX(location.CurrentX);
                    break;
                case Direction.S:
                    location.CurrentX = DecrementX(location.CurrentX);
                    break;
                case Direction.E:
                    location.CurrentY = IncrementY(location.CurrentY);
                    break;
                case Direction.W:
                    location.CurrentY = DecrementY(location.CurrentY);
                    break;
            }
        }

        public void MoveBackward(RoverLocation location)
        {
            switch (location.CurrentDirection)
            {
                case Direction.N:
                    location.CurrentX = DecrementX(location.CurrentX);
                    break;
                case Direction.S:
                    location.CurrentX = IncrementX(location.CurrentX);
                    break;
                case Direction.E:
                    location.CurrentY = DecrementY(location.CurrentY);
                    break;
                case Direction.W:
                    location.CurrentY = IncrementY(location.CurrentY);
                    break;
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
            x++;

            if(x > MaxXCoOrdinate)
            {
                x = 0;
            }

            return x;
        }

        private int DecrementX(int x)
        {
            x--;
            if(x < 0)
            {
                x = MaxXCoOrdinate;
            }

            return x;
        }

        private int IncrementY(int y)
        {
            y++;

            if(y > MaxYCoOrdinate)
            {
                y = 0;
            }

            return y;
        }

        private int DecrementY(int y)
        {
            y--;

            if(y < 0)
            {
                y = MaxYCoOrdinate;
            }

            return y;
        }

        #endregion
    }
}