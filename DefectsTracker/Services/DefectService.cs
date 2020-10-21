using AutoMapper;
using DefectsTracker.Dtos;
using DefectsTracker.Models;
using DefectsTracker.Repositories;
using Microsoft.AspNetCore.JsonPatch;
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
        public DefectReadDto CreateDefect(DefectCreateDto defect)
        {
            Defect defectModel = _mapper.Map<Defect>(defect);
            defectModel.Created = DateTime.Now;
            defectModel.Modified = DateTime.Now;

            _repository.CreateDefect(defectModel);
            _repository.SaveChanges();

            // TODO: manage AutoMapper.AutoMapperMappingException - doesn't not save

            return _mapper.Map<DefectReadDto>(defectModel); ;
        }

        public IEnumerable<DefectReadDto> GetAllDefects()
        {
            var defectsModel = _repository.GetAllDefects();
            var defects = _mapper.Map<IEnumerable<DefectReadDto>>(defectsModel);

            return defects;
        }

        public DefectReadDto GetDefectById(int id)
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

        public DefectReadDto UpdateDefect(int id, DefectUpdateDto defect)
        {
            Defect defectToUpdate = _repository.GetDefectById(id);
            if (defectToUpdate != null)
            {
                _mapper.Map(defect, defectToUpdate);
                defectToUpdate.Modified = DateTime.Now;

                _repository.UpdateDefect(defectToUpdate);
                _repository.SaveChanges();
            }
            
            return _mapper.Map<DefectReadDto>(defectToUpdate);
        }

        public bool PartialUpdateDefect(int id
            , JsonPatchDocument<DefectUpdateDto> patchDoc)
        {
            bool success = false;

            var defectToUpdate = _repository.GetDefectById(id);
            if(defectToUpdate != null)
            {
                //var patchDocument = (JsonPatchDocument<Defect>)patchDoc;
                //var defectToPatch = _mapper.Map<DefectUpdateDto>(defectToUpdate);
                
                var defectModified = _mapper.Map<DefectUpdateDto>(defectToUpdate);
                patchDoc.ApplyTo(defectModified);
                _mapper.Map(defectModified, defectToUpdate);

                defectToUpdate.Modified = DateTime.Now;

                _repository.UpdateDefect(defectToUpdate);
                success = _repository.SaveChanges();

            }

            return success;
        }
    }
}
