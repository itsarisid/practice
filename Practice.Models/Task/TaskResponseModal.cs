using Practice.Models.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models.Task
{
    public class TaskResponseModal
    {
        public TaskResponseModal() {
            TaskModel=new TaskModel();
            AllTask=new List<TaskModel>();
        }
        public TaskModel TaskModel { get; set; }
        public IEnumerable<TaskModel> AllTask { get; set; }
    }
}
