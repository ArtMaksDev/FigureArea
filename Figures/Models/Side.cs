namespace Figures.Models
{
    public class Side
    {
        public string Name { get; }
        public double Value { get; }

        public Side(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
