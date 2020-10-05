using DefectsTracker.Models;
using System;
using System.Collections.Generic;

namespace DefectsTracker.Repositories
{
    public class MockDefect : IDefectRepository
    {
        public void CreateDefect(Defect defect)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Defect> GetAllDefects()
        {
            return new List<Defect>()
            {
                new Defect {
                    Id = 10,
                     Title = "Login does not work",
                      Description = "Filled up user and password, press Login button does not do anything nor it shows any error",
                       AssignedTo = 1,
                       ReportedBy = 1,
                       Created = DateTime.Parse( "2018/01/01 11:50:00"),
                       Modified = DateTime.Parse( "2018/01/01 11:50:00"),
                       Type = 1,
                       Priority = 1
                },
                new Defect {
                    Id = 20,
                     Title = "Login does not work",
                      Description = "Filled up user and password, press Login button does not do anything nor it shows any error",
                       AssignedTo = 1,
                       ReportedBy = 1,
                       Created = DateTime.Parse( "2018/01/01 11:50:00"),
                       Modified = DateTime.Parse( "2018/01/01 11:50:00"),
                       Type = 1,
                       Priority = 1
                },
                new Defect {
                    Id = 30,
                     Title = "Login does not work",
                      Description = "Filled up user and password, press Login button does not do anything nor it shows any error",
                       AssignedTo = 1,
                       ReportedBy = 1,
                       Created = DateTime.Parse( "2018/01/01 11:50:00"),
                       Modified = DateTime.Parse( "2018/01/01 11:50:00"),
                       Type = 1,
                       Priority = 1
                }
            };
        }

        public Defect GetDefectById(int Id)
        {
            return new Defect
            {
                Id = 1,
                Title = "Login does not work",
                Description = "Filled up user and password, press Login button does not do anything nor it shows any error",
                AssignedTo = 1,
                ReportedBy = 1,
                Created = DateTime.Parse("2018/01/01 11:50:00"),
                Modified = DateTime.Parse("2018/01/01 11:50:00"),
                Type = 1,
                Priority = 1
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
