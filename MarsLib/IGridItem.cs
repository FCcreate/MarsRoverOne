        namespace MarsLib
        {
        public interface IGridItem
        {
            int X { get; set; }
            int Y { get; set; }
            bool IsEmpty { get; }
        }
        }