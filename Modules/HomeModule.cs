using Nancy;
using System.Collections.Generic;
using JobBoard.Objects;

namespace JobBoard
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["index.cshtml"];
            Post["/job-posts"] = _ =>  {
                string jobTitle = Request.Form["job-title"];
                string jobDescription = Request.Form["job-description"];
                string contactName = Request.Form["contact-name"];
                string contactEmail = Request.Form["contact-email"];
                string contactPhone = Request.Form["contact-phone"];
                ContactInfo newContact = new ContactInfo(contactName, contactEmail, contactPhone);
                JobOpening newJob = new JobOpening (jobTitle, jobDescription, newContact);
                newJob.Save();
                List<JobOpening> postedJobs = JobOpening.GetAll();
                return View["job_posts.cshtml", postedJobs];
            };
        }
    }
}
