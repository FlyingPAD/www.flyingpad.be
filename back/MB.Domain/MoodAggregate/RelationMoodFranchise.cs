﻿using MB.Domain.FranchiseAggregate;

namespace MB.Domain.MoodAggregate;

public class RelationMoodFranchise
{
    public int MoodId { get; set; }
    public int FranchiseId { get; set; }

    public Mood? Mood { get; set; }
    public Franchise? Franchise { get; set; }
}
