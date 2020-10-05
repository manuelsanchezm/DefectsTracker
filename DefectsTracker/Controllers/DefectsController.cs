﻿using AutoMapper;
using DefectsTracker.Dtos;
using DefectsTracker.Models;
using DefectsTracker.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Internal;
using System;
using System.Collections.Generic;

namespace DefectsTracker.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DefectsController : ControllerBase
    {
        private readonly IDefectRepository _repository;
        private readonly IMapper _mapper;

        public DefectsController(IDefectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: /defects
        [HttpGet]
        public ActionResult<IEnumerable<DefectReadDto>> GetAllDefects()
        {
            var defects = _repository.GetAllDefects();

            return Ok(_mapper.Map<IEnumerable<DefectReadDto>>(defects)) ;
        }

        // GET: /defects/{id}
        [HttpGet("{id}")]
        public ActionResult<DefectReadDto> GetDefectById(int id)
        {
            var defect = _repository.GetDefectById(id);
            if (defect == null)
                return NotFound();

            return Ok(_mapper.Map<DefectReadDto>(defect));
        }

        // POST: /defects
        public ActionResult<DefectReadDto> CreateDefect(DefectCreateDto defectCreateDto)
        {
            var defectModel = _mapper.Map<Defect>(defectCreateDto);
            defectModel.Created = DateTime.Now;
            defectModel.Modified = DateTime.Now;

            _repository.CreateDefect(defectModel);
            _repository.SaveChanges();
            
            return Ok(defectModel);
        }
    }
}
