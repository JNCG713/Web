using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace newAPI.Controllers
{
    public class ContactController : ApiController
    {
        [HttpGet]
        public string[,] GetAll()
        {
            string[,] dat = new string[,] 
            {
                { "Eric", "1980/1/1", "0912345678", "eric@gmail.com", "台北市光復南路179號13樓", "同學" },
                { "Eric", "1980/1/1", "0912345678", "eric@gmail.com", "台北市光復南路179號13樓", "同學" } 
            };
            return dat;
        }
    }
}
