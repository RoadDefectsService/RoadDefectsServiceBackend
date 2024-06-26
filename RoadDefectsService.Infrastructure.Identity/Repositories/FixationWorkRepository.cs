﻿using Microsoft.EntityFrameworkCore;
using RoadDefectsService.Core.Application.Interfaces.Repositories;
using RoadDefectsService.Core.Domain.Models;
using RoadDefectsService.Infrastructure.Identity.Contexts;
using RoadDefectsService.Infrastructure.Identity.Repositories.Base;

namespace RoadDefectsService.Infrastructure.Identity.Repositories
{
    public class FixationWorkRepository : BaseWithBaseEntityRepository<FixationWork, AppDbContext>, IFixationWorkRepository
    {
        public FixationWorkRepository(AppDbContext dbContext) : base(dbContext) { }

        public Task<FixationWork?> GetByIdWithPhotosAndTaskWithPrevTaskAsync(Guid id)
        {
            return _dbContext.FixationWorks
                .Include(fixation => fixation.Photos)
                .Include(fixation => fixation.TaskFixationWork)
                    .ThenInclude(task => task!.PrevTask)
                .FirstOrDefaultAsync(fixation => fixation.Id == id);
        }

        public Task<FixationWork?> GetByIdWithTaskAndPhotosAsync(Guid id)
        {
            return _dbContext.FixationWorks
                .Include(fixation => fixation.TaskFixationWork)
                .Include(fixation => fixation.Photos)
                .FirstOrDefaultAsync(fixation => fixation.Id == id);
        }

        public Task<FixationWork?> GetByIdWithTaskAsync(Guid id)
        {
            return _dbContext.FixationWorks
                .Include(fixation => fixation.TaskFixationWork)
                .FirstOrDefaultAsync(fixation => fixation.Id == id);
        }

        public Task<FixationWork?> GetByIdWithTaskWithPrevTaskWithFixationDefectAsync(Guid id)
        {
            return _dbContext.FixationWorks
                .Include(fixation => fixation.TaskFixationWork)
                    .ThenInclude(task => task!.PrevTask)
                        .ThenInclude(prevTask => prevTask!.FixationDefect)
                .FirstOrDefaultAsync(fixation => fixation.Id == id);
        }
    }
}
