namespace MB.Domain.Entities;

public class RelationMoodTag
{
    public int MoodId { get; set; }
    public int TagId { get; set; }

    public Mood? Mood { get; set; }
    public Tag? Tag { get; set; }
}
