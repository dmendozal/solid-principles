namespace LiskovSubstitution.Problem
{
    abstract class Vehicle
    {
        public virtual void Park() { }
        public virtual void Land() { }
        public virtual void TakeOff() { }
        public virtual void Break() { }
        public virtual void SpeedUp() { }
    }
}