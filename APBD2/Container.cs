namespace APBD2
{
    abstract class Container
    {
        public static double Id { get; set; } = 0;
        public double CargoWeight { get; set; } = 0;
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Depth { get; set; }
        public string SerialNumber {  get; set; }
        public double Capacity { get; set; }

        public Container(double height, double weight, double depth, string type, double capacity)
        {
            Id++;
            Height = height;
            Weight = weight;
            Depth = depth;
            SerialNumber = $"KON-{type}-{Id}";
            Capacity = capacity;
        }

        public virtual void EmptyLoading()
        {
            CargoWeight = 0;
        }

        public virtual void Load(double weight) 
        {
            if(weight + CargoWeight > Capacity) 
            {
                throw new OverfillException($"Container {SerialNumber} overfilled!");
            }
            CargoWeight += weight;
        }

        public override string ToString()
        {
            return $"CargoWeight={CargoWeight}, SerialNumber={SerialNumber}, Capacity={Capacity}";
        }
    }
}
