using AutoMapper;
using DefectsTracker.Dtos;
using DefectsTracker.Models;
using DefectsTracker.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DefectsTracker.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DefectsController : ControllerBase
    {
        private readonly IDefectRepository _repository;
        private readonly IMapper _mapper;

        public DefectsController(IDefectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: /api/defect
        [HttpGet]
        public ActionResult<IEnumerable<DefectReadDto>> GetAllDefects()
        {
            var defects = _repository.GetAllDefects();

            return Ok(_mapper.Map<IEnumerable<DefectReadDto>>(defects)) ;
        }

        // GET: /api/defect/{id}
        [HttpGet("{id}")]
        public ActionResult<DefectReadDto> GetDefectById(int id)
        {
            var defect = _repository.GetDefectById(id);
            if (defect == null)
                return NotFound();

            return Ok(_mapper.Map<DefectReadDto>(defect));
        }
    }
}
