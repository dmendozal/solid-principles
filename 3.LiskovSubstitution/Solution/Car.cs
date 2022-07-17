﻿using LiskovSubstitution.Solution.Interfaces;

namespace LiskovSubstitution.Solution
{
    internal class Car : ISpeedUp, IBreak, IPark
    {
        public void Break()
        {
            // Code to break
        }

        public void Park()
        {
            // Code to park
        }

        public void SpeedUp()
        {
            // Code to speed up
        }
    }
}
