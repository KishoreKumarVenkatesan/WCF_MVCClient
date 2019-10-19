using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace Job_Openings
{
    [DataContract]
    public class JobModel
    {
        [DataMember]
        public Int32 JobID { get; set; }
        [DataMember]
        public string JobName { get; set; }
        [DataMember]
        public string JobRole { get; set; }
        [DataMember]
        public string JobLocation {get; set;}

    }
}