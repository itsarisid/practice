using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        // Initialize  objects.
        public readonly int PAGE_SIZE = 10;

        /// <summary>Called before the action method is invoked.</summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (User != null)
            {
                //TODO: Why this methods is empty.
            }
        }

        /// <summary>Called after the action method is invoked.</summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (User != null)
            {
                //TODO: Why this methods is empty.
            }
            base.OnActionExecuted(filterContext);
        }

        /// <summary>Called when an un-handled exception occurs in the action.</summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected override void OnException(ExceptionContext filterContext)
        {
            //filterContext.ExceptionHandled = true;

            ////TODO: Log error.

            //// Redirect or return a view, but not both.
            //filterContext.Result = new ViewResult
            //{
            //    ViewName = "~/Views/Shared/Error.cshtml"
            //};
        }

        /// <summary>Initializes a new instance of the <see cref="BaseController" /> class.</summary>
        public BaseController()
        {
            //this._log = new Log();
        }
    }
}