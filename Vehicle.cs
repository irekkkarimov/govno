
namespace MyVehicle
{
    abstract class Vehicle
    {
        protected int maxSpeed;
        protected int currSpeed;
        abstract protected int Maxspeed { get; set; }
        abstract protected int Currspeed { get; set; }
        public Vehicle(int ms, int cs)
        {
            maxSpeed = ms;
            currSpeed = cs;
        }

        abstract public void SpeedUp();
        abstract public void SpeedDown();
    }
}
