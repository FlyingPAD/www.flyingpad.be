namespace MB.Domain.Entities
{
    public class Video : Mood
    {
        public int Size { get; set; } = 0;
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;
        public int Duration { get; set; } = 0;
    }
}