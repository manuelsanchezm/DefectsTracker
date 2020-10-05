using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DefectsTracker.Models;

namespace DefectsTracker.Repositories
{
    public interface IDefectRepository
    {
        public IEnumerable<Defect> GetAllDefects();
        public Defect GetDefectById(int Id);
    }
}
