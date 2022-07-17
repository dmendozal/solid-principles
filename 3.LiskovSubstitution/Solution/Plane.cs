using LiskovSubstitution.Solution.Interfaces;

namespace LiskovSubstitution.Solution
{
    internal class Plane : ITakeOff, ILand
    {
        public void Land()
        {
            // Code to land
        }

        public void TakeOff()
        {
            // Code to take off
        }
    }
}
