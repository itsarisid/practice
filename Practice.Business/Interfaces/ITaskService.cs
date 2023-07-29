using Practice.Models.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Business.Interfaces
{
    public interface ITaskService
    {
        /// <summary>Adds the specified task.</summary>
        /// <param name="task">The task.</param>
        void Add(TaskModel task);

        /// <summary>Updates the specified task.</summary>
        /// <param name="task">The task.</param>
        void Update(TaskModel task);

        /// <summary>Deletes the specified task identifier.</summary>
        /// <param name="taskId">The task identifier.</param>
        void Delete(long taskId);

        /// <summary>Gets the by identifier.</summary>
        /// <param name="taskId">The task identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        TaskModel GetById(long taskId);

        /// <summary>Gets all.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        IEnumerable<TaskModel> GetAll();

        /// <summary>Marks the done.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        bool MarkDone(long Id);
    }
}
