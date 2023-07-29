using Practice.Business.Interfaces;
using Practice.Database;
using Practice.Database.Interfaces;
using Practice.Models.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Business.Services
{
    /// <summary>Task Services</summary>
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        /// <summary>Adds the specified task.</summary>
        /// <param name="model"></param>
        /// <exception cref="System.ArgumentNullException">model</exception>
        public void Add(TaskModel model)
        {
            if (model == null) throw new ArgumentNullException("model");
            var task = new Database.Task
            {
                Name = model.Name,
                ExpiryDate = model.ExpiryDate,
                IsImportant = model.IsImportant,
                UserId = model.UserId,
                CreatedDate = DateTime.Now
            };
            _taskRepository.Add(task);
            _taskRepository.Save();
        }

        /// <summary>Deletes the specified task identifier.</summary>
        /// <param name="taskId">The task identifier.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Delete(long taskId)
        {
            throw new NotImplementedException();
        }

        /// <summary>Gets all.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<TaskModel> GetAll()
        {
            var taskList = _taskRepository.GetAll();

            var tasks = new List<TaskModel>();
            foreach (var item in taskList)
            {
                tasks.Add(new TaskModel
                {
                    ID = item.ID,
                    Name = item.Name,
                    ExpiryDate = item.ExpiryDate,
                    IsImportant = item.IsImportant,
                    UserId = item.UserId,
                });
            }
            return tasks;
        }

        /// <summary>Gets the by identifier.</summary>
        /// <param name="taskId">The task identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public TaskModel GetById(long taskId)
        {
            throw new NotImplementedException();
        }

        /// <summary>Marks the done.</summary>
        /// <param name="Id">The identifier.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool MarkDone(long Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>Updates the specified task.</summary>
        /// <param name="task">The task.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Update(TaskModel task)
        {
            throw new NotImplementedException();
        }

    }
}
