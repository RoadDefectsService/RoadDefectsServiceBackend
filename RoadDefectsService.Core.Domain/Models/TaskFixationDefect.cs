﻿namespace RoadDefectsService.Core.Domain.Models
{
    public class TaskFixationDefect : TaskEntity
    {
        public required string ApproximateAddress { get; set; }
        public required string Description { get; set; }
    }
}