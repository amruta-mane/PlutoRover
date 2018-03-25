/// <summary>
/// Class to track rover's exact location
/// </summary>
namespace PlutoRover
{
    public class RoverLocation
    {
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
        public Direction CurrentDirection { get; set; }

        public RoverLocation(int x, int y, Direction direction)
        {
            CurrentX = x;
            CurrentY = y;
            CurrentDirection = direction;
        }
    }
}
