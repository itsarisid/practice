using Practice.Business.Interfaces;
using Practice.Models.Task;
using System.Web.Mvc;

namespace Practice.Web.Controllers
{
    public class HomeController : BaseController
    {
        ITaskService _taskService;

        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        /// <summary>Indexes this instance.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            var modal = new TaskResponseModal();
            modal.AllTask = _taskService.GetAll();
            return View(modal);
        }

        /// <summary>Indexes the specified task.</summary>
        /// <param name="task">The task.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        [HttpPost]
        public ActionResult Index(TaskModel task)
        {
            ViewBag.Title = "Home";
            _taskService.Add(task);
            var modal = new TaskResponseModal();
            modal.AllTask = _taskService.GetAll();
            return View(modal);
        }

        /// <summary>Abouts this instance.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>Contacts this instance.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}