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

        public DefectReadDto GetDefect(int id)
        {
            var defectModel = _repository.GetDefectById(id);
            var defect = _mapper.Map<DefectReadDto>(defectModel);

            return defect;
        }

        public bool DeleteDefect(int id)
        {
            bool success = false;

            var defectModelFromRepository = _repository.GetDefectById(id);
            if (defectModelFromRepository != null)
            {
                _repository.DeleteDefect(defectModelFromRepository);
                success = _repository.SaveChanges();
            }

            return success;
        }
    }
}
