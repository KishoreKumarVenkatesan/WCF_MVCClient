using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
using System.Runtime.Serialization;
using MVCClient.JobService;

namespace MVCClient.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult JobService()
        {
            return View();
        }
        public JsonResult HTTPRequest()
        {
            JobService.JobServiceClient Proxy = new JobService.JobServiceClient();
           List<JobModel> jobList= Proxy.GetListOfJobOpening();
            return Json(jobList, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult HTTPRequestByID(string jobName)
        {
            JobService.JobServiceClient Proxy = new JobService.JobServiceClient();
            
            List<JobModel> jobList = Proxy.GetListOfJobOpeningByRole(jobName);
            return Json(jobList, JsonRequestBehavior.AllowGet);
        }
    }
}