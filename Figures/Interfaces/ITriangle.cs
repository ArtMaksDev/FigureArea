using Figures.Models;

namespace Figures.Interfaces
{
    public interface ITriangle : IFigure
    {
        public Side SideA { get; }
        public Side SideB { get; }
        public Side SideC { get; }
        public bool IsRectangular { get; }
    }
}
