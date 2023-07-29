using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Database.Interfaces
{

    /// <summary>Task Repository</summary>
    public interface ITaskRepository : IRepository<Task>
    {
        void MarkDone(long Id);
    }
}
