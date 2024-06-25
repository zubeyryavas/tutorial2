namespace APBD2
{
    class LContainer : Container, IHazardNotifier
    {
        public LoadType LoadType { get; set; }
        public LContainer(double height, double weight, double depth, double capacity, LoadType loadType) : base(height, weight, depth, "L", capacity) { }

        public void NotifyHazard(string message)
        {
            Console.WriteLine(message);
        }

        public override void Load(double weight) 
        {
            Console.WriteLine(weight + CargoWeight);
            if(this.LoadType == LoadType.Hazard && weight + CargoWeight > Capacity / 2)
            {
                this.NotifyHazard("Loaded too much dangerous load");
            }
            else if (this.LoadType == LoadType.Safe && weight + CargoWeight > Capacity * 0.9)
            {
                this.NotifyHazard("Loaded too much");
            }
            else
            {
                base.Load(weight);
            }
        }
    }

    enum LoadType
    {
        Safe,
        Hazard
    }
}