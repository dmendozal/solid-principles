namespace LiskovSubstitution.Problem
{
    internal class Car : Vehicle
    {
        public override void Break()
        {
            // Code to Break
        }

        public override void Park()
        {
            // Code to park
        }

        public override void SpeedUp()
        {
            // Code to speed up
        }

        public override void TakeOff()
        {
            throw new NotImplementedException();
        }

        public override void Land()
        {
            throw new NotImplementedException();
        }
    }
}
