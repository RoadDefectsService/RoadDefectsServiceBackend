﻿using RoadDefectsService.Core.Application.DTOs.TaskService;
using RoadDefectsService.Core.Application.Models;

namespace RoadDefectsService.Core.Application.Interfaces.Services
{
    public interface ITaskService
    {
        Task<ExecutionResult<TaskPagedDTO>> GetTasksAsync(CommonTaskFilterDTO taskFilter);
        Task<ExecutionResult<TaskPagedDTO>> GetInspectorTasksAsync(TaskFilterDTO taskFilter, Guid inspectorId);
        Task<ExecutionResult> AppointTaskAsync(Guid taskId, Guid inspectorId);
    }
}