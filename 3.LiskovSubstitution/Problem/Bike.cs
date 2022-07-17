namespace LiskovSubstitution.Problem
{
    internal class Bike : Vehicle
    {
        public override void Break()
        {
            // Code to break
        }

        public override void Park()
        {
            // Code to park
        }

        public override void SpeedUp()
        {
            // Code to speed up
        }

        public override void Land()
        {
            throw new NotImplementedException();
        }

        public override void TakeOff()
        {
            throw new NotImplementedException();
        }
    }
}
