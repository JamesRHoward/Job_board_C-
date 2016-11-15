using Nancy;
using System.Collections.Generic;

namespace JobBoard
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["index.cshtml"];
            Post["/job-posts"] = _ =>
            {
            return View["job_posts.cshtml"];
            };
        }
    }
}
