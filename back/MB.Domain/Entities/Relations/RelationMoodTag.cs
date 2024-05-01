namespace MB.Domain.Entities
{
    public class RelationMoodTag
    {
        public int MoodId { get; set; } = 0;
        public int TagId { get; set; } = 0;

        // Navigation Properties :

        public Mood? Mood { get; set; }
        public Tag? Tag { get; set; }
    }
}
