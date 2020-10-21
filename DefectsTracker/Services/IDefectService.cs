using DefectsTracker.Dtos;
using DefectsTracker.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefectsTracker.Services
{
    public interface IDefectService
    {
        DefectReadDto CreateDefect(DefectCreateDto defect);
        IEnumerable<DefectReadDto> GetAllDefects();
        DefectReadDto GetDefectById(int id);
        bool DeleteDefect(int id);
        DefectReadDto UpdateDefect(int id, DefectUpdateDto defect);
        bool PartialUpdateDefect(int id
            , JsonPatchDocument<DefectUpdateDto> patchDoc);
    }
}
