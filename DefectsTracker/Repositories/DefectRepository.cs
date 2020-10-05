using DefectsTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefectsTracker.Repositories
{
    public class DefectRepository : IDefectRepository
    {
        private readonly DefectsTrackerContext _context;

        public DefectRepository(DefectsTrackerContext context)
        {
            _context = context;
        }
        public IEnumerable<Defect> GetAllDefects()
        {
            return _context.Defects.ToList();
        }

        public Defect GetDefectById(int id)
        {
            return _context.Defects.Find(id);
        }
    }
}
