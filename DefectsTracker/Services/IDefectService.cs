using DefectsTracker.Dtos;
using DefectsTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefectsTracker.Services
{
    public interface IDefectService
    {
        Defect CreateDefect(DefectCreateDto defect);
        IEnumerable<DefectReadDto> GetDefects();
        DefectReadDto GetDefect(int id);
        bool DeleteDefect(int id);
    }
}
