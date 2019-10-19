using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Job_Openings
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class JobService : IJobService
    {
        public List<JobModel> GetListOfJobOpening()
        {
            List<JobModel> jobList = new List<JobModel>()
            {
                new JobModel { JobID=101, JobName="IT Specialist", JobRole="Consultant", JobLocation="Bengaluru" },
                new JobModel { JobID=102, JobName="IT Programmer", JobRole="Programmer", JobLocation="Chennai" },
                new JobModel { JobID=103, JobName="IT Manager", JobRole="Tech Lead", JobLocation="Bengaluru" },
                new JobModel { JobID=104, JobName="CustomerService Specialist", JobRole="Consultant", JobLocation="Chennai" },
                new JobModel { JobID=105, JobName="DBA", JobRole="Administrator", JobLocation="Hyderabad" },
            };
            return jobList;
        }

        public List<JobModel> GetListOfJobOpeningByRole(string JobName)
        {
            List<JobModel> searchJobList = new List<JobModel>();
            searchJobList=GetListOfJobOpening().Where(x=>x.JobName.Equals(JobName)).ToList();
            return searchJobList;
        }


    }
}
