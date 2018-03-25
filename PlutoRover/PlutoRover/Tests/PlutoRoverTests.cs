using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PlutoRover
{
    [TestClass]
    public class PlutoRoverTests
    {
        public Grid grid;
        public Rover rover;
        public ObstacleCoOrdinates ObstacleCoOrdinates = new ObstacleCoOrdinates();

        #region Test Set up 

        [TestInitialize]
        public void TestSetUp()
        {
            List<ObstacleCoOrdinates> obstacles = new List<ObstacleCoOrdinates> { new ObstacleCoOrdinates(1, 1) };
            
            grid = new Grid(10, 10, obstacles); 
            rover = new Rover(grid);            
        }

        #endregion

        #region MoveForward

        [TestMethod]
        public void PlutoGridMoveForwardDirectionNorth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.N);
            rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 1);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.N);
        }

        [TestMethod]
        public void PlutoGridMoveForwardDirectionEast()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.E);
            rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 1);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.E);
        }

        [TestMethod]
        public void PlutoGridMoveForwardDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(1, 1, Direction.S);
            rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 1);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.S);
        }

        [TestMethod]
        public void PlutoGridMoveForwardDirectionWest()
        {
            rover.currentPosition = new RoverLocation(1, 1, Direction.W);
            rover.MoveRover("F", out ObstacleCoOrdinates);

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
            rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 1);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.N);
        }

        [TestMethod]
        public void PlutoGridMoveBackwordDirectionEast()
        {
            rover.currentPosition = new RoverLocation(1, 1, Direction.E);
            rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 1);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.E);
        }

        [TestMethod]
        public void PlutoGridMoveBackwordDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.S);
            rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 1);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.S);
        }

        [TestMethod]
        public void PlutoGridMoveBackwordDirectionWest()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.W);
            rover.MoveRover("B", out ObstacleCoOrdinates);

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
            rover.MoveRover("R", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.E);
        }

        [TestMethod]
        public void PlutoGridMoveRightDirectionEast()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.E);
            rover.MoveRover("R", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.S);
        }

        [TestMethod]
        public void PlutoGridMoveRightDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.S);
            rover.MoveRover("R", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.W);
        }

        [TestMethod]
        public void PlutoGridMoveRightDirectionWest()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.W);
            rover.MoveRover("R", out ObstacleCoOrdinates);

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
            rover.MoveRover("L", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.W);
        }

        [TestMethod]
        public void PlutoGridMoveLeftDirectionEast()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.E);
            rover.MoveRover("L", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.N);
        }

        [TestMethod]
        public void PlutoGridMoveLeftDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.S);
            rover.MoveRover("L", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.E);
        }

        [TestMethod]
        public void PlutoGridMoveLeftDirectionWest()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.W);
            rover.MoveRover("L", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.S);
        }

        #endregion

        #region Boundary Detection Test Cases

        [TestMethod]
        public void PlutoGridHitMaxXBoundaryDirectionNorth()
        {
            rover.currentPosition = new RoverLocation(10, 0, Direction.N);
            rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.N);
        }

        [TestMethod]
        public void PlutoGridHitMinXBoundaryDirectionNorth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.N);
            rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 10);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.N);
        }

        [TestMethod]
        public void PlutoGridHitMinXBoundaryDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.S);
            rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 10);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.S);
        }

        [TestMethod]
        public void PlutoGridHitMaxXBoundaryDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(10, 0, Direction.S);
            rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.S);
        }

        [TestMethod]
        public void PlutoGridHitMaxYBoundaryDirectionEast()
        {
            rover.currentPosition = new RoverLocation(0, 10, Direction.E);
            rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.E);
        }

        [TestMethod]
        public void PlutoGridHitMinYBoundaryDirectionEast()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.E);
            rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 10);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.E);
        }

        [TestMethod]
        public void PlutoGridHitMaxYBoundaryDirectionWest()
        {
            rover.currentPosition = new RoverLocation(0, 10, Direction.W);
            rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 0);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.W);
        }

        [TestMethod]
        public void PlutoGridHitMinYBoundaryDirectionWest()
        {
            rover.currentPosition = new RoverLocation(0, 0, Direction.W);
            rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(rover.currentPosition.CurrentX, 0);
            Assert.AreEqual(rover.currentPosition.CurrentY, 10);
            Assert.AreEqual(rover.currentPosition.CurrentDirection, Direction.W);
        }

        #endregion

        #region Obstacle Detection Tests

        [TestMethod]
        public void ObstacleDectectionMoveForwardDirectionNorth()
        {
            rover.currentPosition = new RoverLocation(0, 1, Direction.N);
            RoverLocation location = rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(ObstacleCoOrdinates.XCoOrdinate, 1);
            Assert.AreEqual(ObstacleCoOrdinates.YCoOrdinate, 1);
            Assert.AreEqual(location, rover.currentPosition);            
        }

        [TestMethod]
        public void ObstacleDectectionMoveForwardDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(2, 1, Direction.S);
            RoverLocation location = rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(ObstacleCoOrdinates.XCoOrdinate, 1);
            Assert.AreEqual(ObstacleCoOrdinates.YCoOrdinate, 1);
            Assert.AreEqual(location, rover.currentPosition);
        }

        [TestMethod]
        public void ObstacleDectectionMoveForwardDirectionEast()
        {
            rover.currentPosition = new RoverLocation(1, 0, Direction.E);
            RoverLocation location = rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(ObstacleCoOrdinates.XCoOrdinate, 1);
            Assert.AreEqual(ObstacleCoOrdinates.YCoOrdinate, 1);
            Assert.AreEqual(location, rover.currentPosition);
        }

        [TestMethod]
        public void ObstacleDectectionMoveForwardDirectionWest()
        {
            rover.currentPosition = new RoverLocation(1, 2, Direction.W);
            RoverLocation location = rover.MoveRover("F", out ObstacleCoOrdinates);

            Assert.AreEqual(ObstacleCoOrdinates.XCoOrdinate, 1);
            Assert.AreEqual(ObstacleCoOrdinates.YCoOrdinate, 1);
            Assert.AreEqual(location, rover.currentPosition);
        }

        [TestMethod]
        public void ObstacleDectectionMoveBackwardDirectionNorth()
        {
            rover.currentPosition = new RoverLocation(2, 1, Direction.N);
            RoverLocation location = rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(ObstacleCoOrdinates.XCoOrdinate, 1);
            Assert.AreEqual(ObstacleCoOrdinates.YCoOrdinate, 1);
            Assert.AreEqual(location, rover.currentPosition);
        }

        [TestMethod]
        public void ObstacleDectectionMoveBackwardDirectionSouth()
        {
            rover.currentPosition = new RoverLocation(0, 1, Direction.S);
            RoverLocation location = rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(ObstacleCoOrdinates.XCoOrdinate, 1);
            Assert.AreEqual(ObstacleCoOrdinates.YCoOrdinate, 1);
            Assert.AreEqual(location, rover.currentPosition);
        }

        [TestMethod]
        public void ObstacleDectectionMoveBackwardDirectionEast()
        {
            rover.currentPosition = new RoverLocation(1, 2, Direction.E);
            RoverLocation location = rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(ObstacleCoOrdinates.XCoOrdinate, 1);
            Assert.AreEqual(ObstacleCoOrdinates.YCoOrdinate, 1);
            Assert.AreEqual(location, rover.currentPosition);
        }

        [TestMethod]
        public void ObstacleDectectionMoveBackwardDirectionWest()
        {
            rover.currentPosition = new RoverLocation(1, 0, Direction.W);
            RoverLocation location = rover.MoveRover("B", out ObstacleCoOrdinates);

            Assert.AreEqual(ObstacleCoOrdinates.XCoOrdinate, 1);
            Assert.AreEqual(ObstacleCoOrdinates.YCoOrdinate, 1);
            Assert.AreEqual(location, rover.currentPosition);
        }

        #endregion
    }
}
 