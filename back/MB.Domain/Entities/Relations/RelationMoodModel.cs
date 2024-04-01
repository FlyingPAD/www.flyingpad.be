using MB.Domain.Common;

namespace MB.Domain.Entities
{
    public class RelationMoodModel
    {
        public int MoodId { get; set; } = 0;
        public int ModelId { get; set; } = 0;

        // Navigation Properties :

        public Mood? Mood { get; set; }
        public Model? Model { get; set; }
    }
}
