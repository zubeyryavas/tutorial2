namespace APBD2
{
    class GContainer : Container, IHazardNotifier
    {
        public GContainer(double height, double weight, double depth, double capacity) : base(height, weight, depth, "G", capacity) { }
        public override void EmptyLoading()
        {
            CargoWeight *= 0.05;
        }

        public void NotifyHazard(string message)
        {
            Console.WriteLine(message + ": #" + SerialNumber);
        }
    }
}
