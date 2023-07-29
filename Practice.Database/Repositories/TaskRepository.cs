using Practice.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Database.Repositories
{
    /// <summary>Task Repository</summary>
    public class TaskRepository : Repository<PracticeEntities, Task>, ITaskRepository
    {
        /// <summary>Marks the task done.</summary>
        /// <param name="Id">The identifier.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void MarkDone(long Id)
        {
            throw new NotImplementedException();
        }
    }
}
