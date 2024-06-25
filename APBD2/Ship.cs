namespace APBD2
{
    class Ship
    {
        public List<Container> Containers { get; set; } = new List<Container>();
        public double Speed { get; set; }
        public double CurrentWeight { get; set; }
        public int MaxNumberOfContainers { get; set; }
        public double MaxWeightOfLoading { get; set; }

        public Ship(double speed, int maxNumberOfContainers, double maxWeightOfLoading)
        {
            Speed = speed;
            MaxNumberOfContainers = maxNumberOfContainers;
            MaxWeightOfLoading = maxWeightOfLoading;
        }

        public void LoadContainer(Container container)
        {
            if(container.Weight + CurrentWeight > MaxWeightOfLoading * 1000 || MaxNumberOfContainers == Containers.Count)
            {
                Console.WriteLine("Cannot add more containers");
            } 
            else
            {
                CurrentWeight += container.Weight;
                Containers.Add(container);
            }
        }

        public void LoadContainers(List<Container> containers)
        {
            Containers.AddRange(containers);
        }

        public void RemoveContainer(Container container)
        {
            Containers.Remove(container);
        }

        public Container UnloadContainer()
        {
            return Containers.Last();
        }

        public void MoveContainerToOtherShip(Ship ship, Container container)
        {
            ship.LoadContainer(container);
            RemoveContainer(container);
        }

        public override string ToString()
        {
            return $"Current Weight: {CurrentWeight}, Speed: {Speed} ";
        }
    }
}
