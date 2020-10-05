using DefectsTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

        public void CreateDefect(Defect defect)
        {
            if(defect == null)
            {
                throw new ArgumentNullException(nameof(defect));
            }

            _context.Defects.Add(defect);
        }

        public IEnumerable<Defect> GetAllDefects()
        {
            return _context.Defects.ToList();
        }

        public Defect GetDefectById(int id)
        {
            return _context.Defects.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
