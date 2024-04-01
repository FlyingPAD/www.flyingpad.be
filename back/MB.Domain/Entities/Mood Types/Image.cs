namespace MB.Domain.Entities
{
    public class Image : Mood
    {
        public int Size { get; set; } = 0;
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;
    }
}