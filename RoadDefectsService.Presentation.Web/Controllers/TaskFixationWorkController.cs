﻿using Microsoft.AspNetCore.Mvc;
using RoadDefectsService.Core.Application.DTOs.TaskService;
using RoadDefectsService.Core.Application.Interfaces.Services;
using RoadDefectsService.Core.Domain.Enums;
using RoadDefectsService.Presentation.Web.Attributes;
using RoadDefectsService.Presentation.Web.Controllers.Base;
using RoadDefectsService.Presentation.Web.DTOs;

namespace RoadDefectsService.Presentation.Web.Controllers
{
    [Route("api/fixation_work_task")]
    [ApiController]
    [SwaggerControllerOrder(Order = 9)]
    public class TaskFixationWorkController : BaseController
    {
        private readonly ITaskFixationWorkService _taskFixationWorkService;

        public TaskFixationWorkController(ITaskFixationWorkService taskFixationWorkService)
        {
            _taskFixationWorkService = taskFixationWorkService;
        }

        /// <summary>
        /// Посмотреть задачу по фиксации выполненных работ 
        /// </summary>
        /// <remarks>
        /// Доступ: Все 
        /// 
        /// Инспектор может посмотреть только свои задачи
        /// </remarks>
        [HttpGet("{taskId}")]
        [CustomeAuthorize]
        [ProducesResponseType(typeof(FixationWorkTaskDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FixationWorkTaskDTO>> GetFixationWorkTask([FromRoute] Guid taskId)
        {
            if (HttpContext.User.IsInRole(Role.RoadInspector))
            {
                return await ExecutionResultHandlerAsync((userId) => _taskFixationWorkService.GetFixationWorkTaskAsync(taskId, userId));
            }
            return await ExecutionResultHandlerAsync(() => _taskFixationWorkService.GetFixationWorkTaskAsync(taskId));
        }

        ///// <summary>
        ///// Редактировать задачу по фиксации выполненных работ (Не реализовано) (Не все модели указаны)
        ///// </summary> 
        ///// <remarks> Доступ: Оператор и админ </remarks>
        //[HttpPut("{taskId}")]
        //[CustomeAuthorize(Roles = Role.Operator)]
        //[ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status404NotFound)]
        //public async Task<ActionResult> ChangeFixationWorkTask([FromRoute] Guid taskId, [FromBody] EditFixationWorkTaskDTO editFixationWork)
        //{
        //    return NoContent();
        //}

        /// <summary>
        /// Создать задачу по фиксации выполненных работ
        /// </summary>
        /// <remarks> 
        /// Доступ: Оператор и админ 
        /// 
        /// Если поставить флаг IsTransfer, то это будет означать, что она используется для переноса данных из бумажного в электронный вид
        /// </remarks>
        [HttpPost]
        [CustomeAuthorize(Roles = Role.Operator)]
        [ProducesResponseType(typeof(CreateTaskResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CreateTaskResponseDTO>> CreateFixationWorkTask([FromBody] CreateFixationWorkTaskDTO createFixationWork)
        {
            return await ExecutionResultHandlerAsync(() => _taskFixationWorkService.CreateFixationWorkTaskAsync(createFixationWork));
        }
    }
}
