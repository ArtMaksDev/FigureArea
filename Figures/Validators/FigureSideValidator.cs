using Figures.Exceptions;
using Figures.Models;

namespace Figures.Validators
{
    public class FigureSideValidator
    {
        protected void CheckSides(params Side[] sides)
        {
            Argument.NotNull(sides, nameof(sides));

            foreach (var side in sides)
            {
                if (!Argument.IsMoreThat0(side.Value))
                {
                    throw new SideIsNotPositiveException(side);
                }
            }

        }
    }
}