namespace MB.Domain.Entities
{
    public class RelationMoodFranchise
    {
        public int MoodId { get; set; }
        public int FranchiseId { get; set; }

        // Navigation Properties
        public Mood? Mood { get; set; }
        public Franchise? Franchise { get; set; }
    }
}
