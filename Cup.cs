namespace SevenElevenShakeStation
{
    public enum CupSize { Small, Medium, Large }

    public class Cup
    {
        public CupSize Size { get; set; }
        public string Type { get; set; }

        public Cup(CupSize size, string type)
        {
            Size = size;
            Type = type;
        }

        public CupSize GetSize() { return Size; }
        public string GetType() { return Type; }
    }
}