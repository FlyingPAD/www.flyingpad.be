namespace MB.Domain.Entities
{
    public class Video : Mood
    {
        public int Size { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Duration { get; set; }
    }
}