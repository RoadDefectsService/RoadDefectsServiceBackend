﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using RoadDefectsService.Presentation.Web.DTOs;
using System.Collections.Immutable;

namespace RoadDefectsService.Presentation.Web.Attributes
{
    public class ValidateModelStateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ModelState.IsValid) return;

            ImmutableDictionary<string, List<string>> errors = ImmutableDictionary<string, List<string>>.Empty;
            foreach (var key in context.ModelState.Keys)
            {
                var modelStateEntry = context.ModelState[key]!;

                var errorMessages = new List<string>();
                foreach (var error in modelStateEntry.Errors)
                {
                    errorMessages.Add(error.ErrorMessage);
                }

                errors = errors.Add(key, errorMessages);
            }

            context.Result = new BadRequestObjectResult(new ErrorResponse()
            {
                Title = "One or more validation errors occurred.",
                Status = 400,
                Errors = errors,
            });
        }
    }
}
