using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DefectsTracker.Models;

namespace DefectsTracker.Repositories
{
    public interface IDefectRepository
    {
        public bool SaveChanges();

        IEnumerable<Defect> GetAllDefects();
        Defect GetDefectById(int Id);
        void CreateDefect(Defect defect);
        void UpdateDefect(Defect defect);
    }
}
