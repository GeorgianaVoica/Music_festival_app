using Proiect.Database;
using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public class StageRepository:IStageRepository
    {
        public void Add(Stage stage)
        {
            //stage.Id = Guid.NewGuid();
            FakeDatabase.stages.Add(stage);
        }

        public void Delete(Stage stage)
        {
            FakeDatabase.stages.Remove(stage);
        }

        public List<Stage> GetAll()
        {
            return FakeDatabase.stages;
        }

        public Stage GetById(int Id)
        {
            return FakeDatabase.stages.FirstOrDefault(x=> x.Id == Id);
        }
    }
}
