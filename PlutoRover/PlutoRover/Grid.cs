using System;
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
        }

        #endregion

        #region Grid Move Methods

        public void MoveForward(RoverLocation location)
        {

        }

        public void MoveBackward(RoverLocation location)
        {

        }

        public void MoveRight(RoverLocation location)
        {

        }

        public void MoveLeft(RoverLocation location)
        {

        }

        #endregion
    }
}
