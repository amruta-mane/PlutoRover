using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlutoRover
{
    [TestClass]
    public class PlutoRoverTests
    {
        public Grid grid;
        public Rover rover;

        #region Test Set up 

        [TestInitialize]
        public void TestSetUp()
        {
            grid = new Grid(10, 10); 
            rover = new Rover(grid);
        }

        #endregion

        #region MoveForward

        [TestMethod]
        public void PlutoGridMoveForwardDirectionNorth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.N);
            rover.MoveRover("F");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 1);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.N);
        }

        [TestMethod]
        public void PlutoGridMoveForwardDirectionEast()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.E);
            rover.MoveRover("F");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 1);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.E);
        }

        [TestMethod]
        public void PlutoGridMoveForwardDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(1, 1, Direction.S);
            rover.MoveRover("F");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 1);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.S);
        }

        [TestMethod]
        public void PlutoGridMoveForwardDirectionWest()
        {
            rover.currentPosition = new RoverLocation(1, 1, Direction.W);
            rover.MoveRover("F");

            Assert.AreEqual(rover.currentPosition.CurrentX, 1);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.W);
        }

        #endregion 

        #region MoveBackward

        [TestMethod]
        public void PlutoGridMoveBackwordDirectionNorth()
        {
            rover.currentPosition = new RoverLocation(1, 1, Direction.N);
            rover.MoveRover("B");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 1);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.N);
        }

        [TestMethod]
        public void PlutoGridMoveBackwordDirectionEast()
        {
            rover.currentPosition = new RoverLocation(1, 1, Direction.E);
            rover.MoveRover("B");

            Assert.AreEqual(rover.currentPosition.CurrentX, 1);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.E);
        }

        [TestMethod]
        public void PlutoGridMoveBackwordDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.S);
            rover.MoveRover("B");

            Assert.AreEqual(rover.currentPosition.CurrentX, 1);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.S);
        }

        [TestMethod]
        public void PlutoGridMoveBackwordDirectionWest()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.W);
            rover.MoveRover("B");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 1);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.W);
        }

        #endregion

        #region MoveRight

        [TestMethod]
        public void PlutoGridMoveRightDirectionNorth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.N);
            rover.MoveRover("R");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.E);
        }

        [TestMethod]
        public void PlutoGridMoveRightDirectionEast()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.E);
            rover.MoveRover("R");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.S);
        }

        [TestMethod]
        public void PlutoGridMoveRightDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.S);
            rover.MoveRover("R");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.W);
        }

        [TestMethod]
        public void PlutoGridMoveRightDirectionWest()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.W);
            rover.MoveRover("R");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.N);
        }

        #endregion

        #region MoveLeft

        [TestMethod]
        public void PlutoGridMoveLeftDirectionNorth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.N);
            rover.MoveRover("L");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.W);
        }

        [TestMethod]
        public void PlutoGridMoveLeftDirectionEast()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.E);
            rover.MoveRover("L");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.N);
        }

        [TestMethod]
        public void PlutoGridMoveLeftDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.S);
            rover.MoveRover("L");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.E);
        }

        [TestMethod]
        public void PlutoGridMoveLeftDirectionWest()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.W);
            rover.MoveRover("L");

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.S);
        }

        #endregion
    }
}
