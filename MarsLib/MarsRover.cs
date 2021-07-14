using System;

namespace MarsLib
{
    public class MarsRover : IGridItem
    {
        public MarsRover()
        {
        }

        public int X { get ; set ; } = 0;
        public int Y { get ; set ; } = 0;

        public bool IsEmpty  { get; set ; } = true;


    }
}
