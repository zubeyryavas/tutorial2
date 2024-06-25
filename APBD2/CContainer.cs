namespace APBD2
{
    class CContainer : Container
    {
        public Product Product { get; set; }
        public float Temperature { get; set; }
        public CContainer(double height, double weight, double depth, double capacity, Product product) : base(height, weight, depth, "C", capacity)
        {
            Product = product;
            Temperature = (float)product / 10;
        }

        public void Load(double weight, double temperature)
        {
            if(temperature >= Temperature)
            {
                this.Load(weight);
            }
            else
            {
                Console.WriteLine("Temperature cannot be lower than " + Temperature);
            }
        }
        
    }

    enum Product
    {
        Bananas = 133,
        Chocolate = 180,
        Fish = 20,
        Meat = -150,
        IceCream = -180,
        FrozenPizza = -300,
        Cheese = 72,
        Sausages = 50,
        Butter =  205,
        Eggs = 190,
    }
}
