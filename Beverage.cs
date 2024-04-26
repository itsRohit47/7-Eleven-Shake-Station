namespace SevenElevenShakeStation
{
    public abstract class Beverage
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Beverage(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string GetName() { return Name; }
        public string GetDescription() { return Description; }
    }
}