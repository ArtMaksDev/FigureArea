namespace Figures.Validators
{
    public static class Argument
    {
        public static bool IsMoreThat0(double value)
        {
            return value > 0;
        }

        public static void NotNull(object? param, string paramName)
        {
            ArgumentNullException.ThrowIfNull(param, paramName);
        }
    }
}
