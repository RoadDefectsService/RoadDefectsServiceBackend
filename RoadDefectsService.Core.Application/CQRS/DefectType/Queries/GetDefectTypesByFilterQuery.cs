﻿using AutoMapper;
using MediatR;
using RoadDefectsService.Core.Application.CQRS.DefectType.DTOs;
using RoadDefectsService.Core.Application.Interfaces.Repositories;
using RoadDefectsService.Core.Application.Models;
using RoadDefectsService.Core.Domain.Models;

namespace RoadDefectsService.Core.Application.CQRS.DefectType.Queries
{
    public class GetDefectTypesByFilterQuery : IRequest<ExecutionResult<List<DefectTypeDTO>>>
    {
        public required DefectTypeFilterDTO DefectTypeFilter { get; set; }

        public class GetDefectTypesByFilterQueryHandler : IRequestHandler<GetDefectTypesByFilterQuery, ExecutionResult<List<DefectTypeDTO>>>
        {
            private readonly IDefectTypeRepository _defectTypeRepository;
            private readonly IMapper _mapper;

            public GetDefectTypesByFilterQueryHandler(IDefectTypeRepository defectTypeRepository, IMapper mapper)
            {
                _defectTypeRepository = defectTypeRepository;
                _mapper = mapper;
            }

            public async Task<ExecutionResult<List<DefectTypeDTO>>> Handle(GetDefectTypesByFilterQuery request, CancellationToken cancellationToken)
            {
                List<DefectTypeEntity> defectTypes = await _defectTypeRepository.GetAllByFilterAsync(request.DefectTypeFilter);

                return _mapper.Map<List<DefectTypeDTO>>(defectTypes);
            }
        }
    }
}
