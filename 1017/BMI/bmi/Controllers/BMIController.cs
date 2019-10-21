using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace BMI.Controllers
{


    public class BMIController : ApiController
    {
        [HttpPost]

        public IHttpActionResult Post(BMIParam para)
        {
            
            para.height /= 100;
            var bmi = para.weight / (para.height * para.height);
            var ret = new BMIResult() { BMI = bmi };
            return Ok(ret);
        }
    }
    public class BMIResult
    {
        public float BMI { get; set; }
    }

    public class BMIParam
    {
        public float height { get; set; }
        public float weight { get; set; }
    }
}
