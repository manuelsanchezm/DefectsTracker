using DefectsTracker.Dtos;
using DefectsTracker.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefectsTracker.Profiles
{
    public class DefectProfile : Profile
    {
        public DefectProfile()
        {
            CreateMap<Defect, DefectReadDto>();
            CreateMap<DefectCreateDto, Defect>();
            CreateMap<DefectUpdateDto, Defect>();
        }
        
    }
}
