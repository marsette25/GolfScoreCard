//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using GolfScoreCard.Models;
//using System.Web.Mvc;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.Owin;
//using Microsoft.Owin.Security;

//namespace GolfScoreCard.Controllers
//{
//    public class GolfCourseInformationController : ApiController
//    {
//        private GolfCourseInformationContext db = new GolfCourseInformationContext();

//        [System.Web.Http.HttpGet]
//        public IEnumerable<GolfCourseInformationContext> Get()
//        {
//            return db.GolfCourseInformation.AsEnumerable();
//        }

//        // GET: api/GolfCourseInformation

//        public IEnumerable<string> GET()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET: api/GolfCourseInformation/5
//        public GolfCourseInformation Get(int id)
//        {
//            return db.GolfCourses.AsEnumerable();
//        }

//        // POST: api/GolfCourseInformation
//        public void Post([FromBody]string value)
//        {
//        }

//        // PUT: api/GolfCourseInformation/5
//        public void Put(int id, [FromBody]string value)
//        {
//        }

//        // DELETE: api/GolfCourseInformation/5
//        public void Delete(int id)
//        {
//        }
//    }
//}
