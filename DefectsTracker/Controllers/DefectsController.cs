using DefectsTracker.Dtos;
using DefectsTracker.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DefectsTracker.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DefectsController : ControllerBase
    {
        private readonly IDefectService _defectService;

        public DefectsController(IDefectService defectService)
        {
            _defectService = defectService;
        }

        // GET: api/defects
        [HttpGet]
        public ActionResult<IEnumerable<DefectReadDto>> GetAllDefects()
        {
            var defects = _defectService.GetAllDefects();
            if (defects == null)
                return NotFound();

            return Ok(defects);
        }

        // GET: api/defects/{id}
        [HttpGet("{id}", Name = "GetDefectById")]
        public IActionResult GetDefectById(int id)
        {
            var defect = _defectService.GetDefectById(id);
            if (defect == null)
                return NotFound(); // 404

            return Ok(defect);
        }

        // POST: api/defects
        public IActionResult CreateDefect(DefectCreateDto defect)
        {
            var defectCreated = _defectService.CreateDefect(defect);

            return CreatedAtRoute(nameof(GetDefectById), new { id = defectCreated.Id }, defectCreated);
        }

        // PUT: api/defects/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateDefect(int id, DefectUpdateDto defect)
        {
            if (defect == null)
                return BadRequest();

            var defectModelFromRepository = _defectService.UpdateDefect(id, defect);

            if (defectModelFromRepository == null)
                return NotFound(); // 404

            return CreatedAtRoute(nameof(GetDefectById), new { id = defectModelFromRepository.Id }, defectModelFromRepository);
        }

        // PATCH: api/defects/{id}
        [HttpPatch("{id}")]
        public IActionResult DefectPartialUpdate(int id, JsonPatchDocument<DefectUpdateDto> patchDoc)
        {
            if (!TryValidateModel(ModelState))
                return ValidationProblem(ModelState);



            _defectService.PartialUpdateDefect(id, patchDoc);

            return NoContent();
        }

        // DELETE: api/defects/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteDefect(int id)
        {
            var resultAction = _defectService.DeleteDefect(id);
            if (!resultAction)
                return NotFound(); // 404 

            return NoContent();
        }
    }
}
