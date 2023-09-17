using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public interface IStageRepository
    {
        void Add(Stage stage);
        void Delete(Stage stage);
        List<Stage> GetAll();
        Stage GetById(int Id);
    }
}
