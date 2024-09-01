namespace MB.Domain.Entities;

public class RelationMoodModel
{
    public int MoodId { get; set; }
    public int ModelId { get; set; }

    public Mood? Mood { get; set; }
    public Model? Model { get; set; }
}
