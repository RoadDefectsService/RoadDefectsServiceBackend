﻿using RoadDefectsService.Core.Domain.Enums;

namespace RoadDefectsService.Core.Application.DTOs
{
    public class TaskDTO
    {
        public required Guid Id { get; set; }
        public required DateTime CreatedDateTime { get; set; }
        public required TaskType TaskType { get; set; }
        public required DefectStatus DefectStatus { get; set; }
        public required DefectFixationShortInfoDTO? DefectFixation { get; set; }
    }
}
