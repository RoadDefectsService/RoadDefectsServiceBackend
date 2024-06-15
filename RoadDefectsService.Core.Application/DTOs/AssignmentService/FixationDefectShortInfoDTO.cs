﻿namespace RoadDefectsService.Core.Application.DTOs.AssignmentService
{
    public class FixationDefectShortInfoDTO
    {
        public required Guid Id { get; set; }
        public required string? ExactAddress { get; set; }
        public required double? DamagedCanvasSquareMeter { get; set; }
        public required string? DefectTypeName { get; set; }
    }
}
