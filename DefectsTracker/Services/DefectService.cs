using AutoMapper;
using DefectsTracker.Dtos;
using DefectsTracker.Models;
using DefectsTracker.Repositories;
using System;
using System.Collections.Generic;

namespace DefectsTracker.Services
{
    public class DefectService : IDefectService
    {
        private readonly IDefectRepository _repository;
        private readonly IMapper _mapper;

        public DefectService(IDefectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public Defect CreateDefect(DefectCreateDto defect)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DefectReadDto> GetDefects()
        {
            var defectsModel = _repository.GetAllDefects();

            var defects = _mapper.Map<IEnumerable<DefectReadDto>>(defectsModel);

            return defects;
        }
    }
}
