using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using I9.$resource$.Interfaces;

namespace I9.$resource$.Api.Controllers
{
    public class $resource$Controller : ApiController
    {
        private IDomainEntity domainResource;
        private I$resource$Repository $resourceLowerCase$Repo;
        public $resource$Controller(IDomainEntity resource, I$resource$Repository repo)
        {
            this.domainResource = resource;
            this.$resourceLowerCase$Repo = repo;
        }
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }
    }
}
