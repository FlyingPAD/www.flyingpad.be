using MB.Domain.ModelAggregate;

namespace MB.Domain.MoodAggregate;

public class RelationMoodModel
{
    public int MoodId { get; set; }
    public int ModelId { get; set; }

    public Mood? Mood { get; set; }
    public Model? Model { get; set; }
}
